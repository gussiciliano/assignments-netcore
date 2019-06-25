using System.Collections.Generic;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AssignmentsNetcore.Controllers
{
    [Route("backoffice/[controller]")]
    public class ProjectComponentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectComponentController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(UnitOfWork.ProjectComponentRepository.GetAll().Select(pc => new ProjectComponentViewModel(pc)).ToList());

        [HttpGet("Details")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectComponentRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectComponentViewModel(workingEntity));
        }

        [HttpGet("Create")]
        public IActionResult Create()
            => View(new ProjectComponentFormViewModel(UnitOfWork.TechRepository.GetAll(), UnitOfWork.ProjectRepository.GetAll()));

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProjectComponentFormViewModel projectComponentViewModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return View(projectComponentViewModel);
            }

            UnitOfWork.ProjectComponentRepository.Add(new ProjectComponent(projectComponentViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ProjectComponent projectComponent = UnitOfWork.ProjectComponentRepository.Get(id.Value);
            if (projectComponent == null) return NotFound();
            return View(new ProjectComponentFormViewModel(projectComponent,
                                                        UnitOfWork.TechRepository.GetAll(),
                                                        UnitOfWork.ProjectRepository.GetAll()));
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProjectComponentFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
                return View(workingViewModel);
            ProjectComponent pc = UnitOfWork.ProjectComponentRepository.Get(id);
            UnitOfWork.ProjectComponentRepository.Update(pc.Update(workingViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectComponentRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectComponentViewModel(workingEntity));
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            UnitOfWork.ProjectComponentRepository.Remove(UnitOfWork.ProjectComponentRepository.Get(id));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
