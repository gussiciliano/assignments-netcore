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
    public class ProjectController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(UnitOfWork.ProjectRepository.GetAll().Select(p => new ProjectViewModel(p)).ToList());

        [HttpGet("Details")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectViewModel(workingEntity));
        }

        [HttpGet("Create")]
        public IActionResult Create()
            => View(new ProjectFormViewModel(UnitOfWork.TechRepository.GetAll(), UnitOfWork.TabRepository.GetAll()));

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProjectFormViewModel projectViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(projectViewModel);
            }
            UnitOfWork.ProjectRepository.Add(new Project(projectViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Project project = UnitOfWork.ProjectRepository.Get(id.Value);
            if (project == null) return NotFound();
            return View(new ProjectFormViewModel(project,
                                                        UnitOfWork.TechRepository.GetAll(),
                                                        UnitOfWork.TabRepository.GetAll()));
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProjectFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
                return View(workingViewModel);
            Project p = UnitOfWork.ProjectRepository.Get(id);
            UnitOfWork.ProjectRepository.Update(p.Update(workingViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectViewModel(workingEntity));
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            UnitOfWork.ProjectRepository.Remove(UnitOfWork.ProjectRepository.Get(id));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
