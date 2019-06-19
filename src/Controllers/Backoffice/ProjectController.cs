using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(UnitOfWork.ProjectRepository.GetAll().Select(r => new ProjectViewModel(r)).ToList());

        [HttpGet("Details/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectViewModel(workingEntity));
        }

        [HttpGet("Create")]
        public IActionResult Create() => View(new ProjectFormViewModel(UnitOfWork.ClientRepository.GetAll()));

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProjectFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid) {
                var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y=>y.Count>0)
                           .ToList();
                           return View(workingViewModel);
            }
            UnitOfWork.ProjectRepository.Add(new Project(workingViewModel));
            UnitOfWork.Complete();    
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.ProjectRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectFormViewModel(workingEntity, UnitOfWork.ClientRepository.GetAll(), UnitOfWork.ProjectComponentRepository.GetAll()));
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProjectFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
                return View(workingViewModel);
            Project project = UnitOfWork.ProjectRepository.Get(id);
            project.Update(workingViewModel);
            UnitOfWork.ProjectRepository.Update(project);
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
            try
            {
                UnitOfWork.ProjectRepository.Remove(UnitOfWork.ProjectRepository.Get(id));
                UnitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }
    }
}
