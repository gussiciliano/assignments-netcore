using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    public class ProjectComponentController : CRUDController<ProjectComponent, ProjectComponentViewModel>
    {
        public ProjectComponentController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IActionResult Create() => View(new ProjectComponentFormViewModel(UnitOfWork.TechRepository.GetAll(), UnitOfWork.ProjectRepository.GetAll()));

        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new ProjectComponentFormViewModel(workingEntity, UnitOfWork.TechRepository.GetAll(), UnitOfWork.ProjectRepository.GetAll()));
        }

        protected override IRepository<ProjectComponent> WorkingRepository { get { return UnitOfWork.ProjectComponentRepository; } }

        protected override ProjectComponent CreateNewEntity(ProjectComponentViewModel workingViewModel) =>
            new ProjectComponent(workingViewModel);

        protected override ProjectComponentViewModel CreateNewViewModel(ProjectComponent entity) =>
            new ProjectComponentViewModel(entity);

        protected override ProjectComponent EditEntityByViewModel(ProjectComponent entity, ProjectComponentViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
