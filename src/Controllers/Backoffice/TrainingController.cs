using System;
using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    public class TrainingController : CRUDController<Training, TrainingViewModel>
    {
        public TrainingController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Training> WorkingRepository { get { return UnitOfWork.TrainingRepository; } }

        public override IActionResult Create() => View(new TrainingFormViewModel(UnitOfWork.ClientRepository.GetAll(), UnitOfWork.ProjectComponentRepository.GetAll()));

        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var trainingFormViewModel = new TrainingFormViewModel(workingEntity, UnitOfWork.ClientRepository.GetAll(), UnitOfWork.ProjectComponentRepository.GetAll());
            return View(trainingFormViewModel);
        }

        protected override Training CreateNewEntity(TrainingViewModel workingViewModel) => new Training(workingViewModel);

        // TODO: deprecated
        protected override TrainingViewModel CreateNewViewModel(Training entity) => null;

        protected override Training EditEntityByViewModel(Training entity, TrainingViewModel workingViewModel) => entity.Update(workingViewModel);
    }
}
