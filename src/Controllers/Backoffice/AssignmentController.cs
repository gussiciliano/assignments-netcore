using System;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    [Route("backoffice/[controller]")]
    public class AssignmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHtmlLocalizer<AssignmentController> _localizer;
        public AssignmentController(IUnitOfWork unitOfWork, IHtmlLocalizer<AssignmentController> localizer)
        {
            this._unitOfWork = unitOfWork;
            this._localizer = localizer;
        }

        public IUnitOfWork UnitOfWork { get => this._unitOfWork; }
        public IHtmlLocalizer<AssignmentController> Localizer { get => this._localizer; }

        [HttpGet("")]
        public IActionResult Index() =>
            View(UnitOfWork.AssignmentRepository.GetAll().Select(assignment => new AssignmentViewModel(assignment)));

        [HttpGet("Create")]
        public IActionResult Create()
        {
            var viewModel = new AssignmentFormViewModel(UnitOfWork.TechRepository.GetAll(),
                                            UnitOfWork.PersonRepository.GetAll(),
                                            UnitOfWork.ProjectRepository.GetAll(),
                                            UnitOfWork.PositionRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost("Create")]
        public IActionResult Create(AssignmentFormViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var assignment = new Assignment(viewModel);
                    UnitOfWork.AssignmentRepository.Add(assignment);
                    UnitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(viewModel);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(viewModel);
            }
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var viewModel = new AssignmentFormViewModel(UnitOfWork.AssignmentRepository.Get(id.Value),
                                            UnitOfWork.TechRepository.GetAll(),
                                            UnitOfWork.PersonRepository.GetAll(),
                                            UnitOfWork.ProjectRepository.GetAll(),
                                            UnitOfWork.PositionRepository.GetAll());
            if (viewModel == null) return NotFound();
            return View(viewModel);
        }

        [HttpPost("Edit/{id}")]
        public IActionResult Edit(int id, AssignmentFormViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var assignment = UnitOfWork.AssignmentRepository.Get(viewModel.Id);
                    assignment.Update(viewModel);
                    UnitOfWork.AssignmentRepository.Update(assignment);
                    UnitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(viewModel);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(viewModel);
            }
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var viewModel = new AssignmentViewModel(UnitOfWork.AssignmentRepository.Get(id));
            return View(viewModel);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var assignment = UnitOfWork.AssignmentRepository.Get(id.Value);
            if (assignment == null) return NotFound();
            return View(new AssignmentViewModel(assignment));
        }

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            UnitOfWork.AssignmentRepository.Remove(UnitOfWork.AssignmentRepository.Get(id));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
