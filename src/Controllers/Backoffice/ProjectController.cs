using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    public class ProjectController : CRUDController<Project, ProjectViewModel>
    {
        public ProjectController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        protected override IRepository<Project> WorkingRepository { get { return UnitOfWork.ProjectRepository; } }

        public override IActionResult Create() => View(new ProjectFormViewModel(UnitOfWork.ClientRepository.GetAll()));

        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectFormViewModel(workingEntity, UnitOfWork.ClientRepository.GetAll(), UnitOfWork.ProjectComponentRepository.GetAll()));
        }

        protected override Project CreateNewEntity(ProjectViewModel workingViewModel) =>
            new Project(workingViewModel);

        protected override ProjectViewModel CreateNewViewModel(Project entity) =>
            new ProjectViewModel(entity);

        protected override Project EditEntityByViewModel(Project entity, ProjectViewModel workingViewModel) => entity.Update(workingViewModel);
    }
}
