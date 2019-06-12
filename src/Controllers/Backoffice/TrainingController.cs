using System;
using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    public class TrainingController : CRUDController<Training, TrainingViewModel>
    {
        public TrainingController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Training> WorkingRepository { get { return UnitOfWork.TrainingRepository; } }

        public override IActionResult Create()
        {
            var trainingViewModel = new TrainingViewModel();
            //trainingViewModel.Clients = UnitOfWork.ClientRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(trainingViewModel);
        }
        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var trainingViewModel = CreateNewViewModel(workingEntity);
            // trainingViewModel.Clients = UnitOfWork.ClientRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(trainingViewModel);
        }

        protected override Training CreateNewEntity(TrainingViewModel workingViewModel)
        {
            Training training = new Training();
            training.Name = workingViewModel.Name;
            training.StartDate = workingViewModel.StartDate;
            training.EndDate = workingViewModel.EndDate;
            training.TrainingStatus = workingViewModel.TrainingStatus;
            training.ClientId = workingViewModel.Client.Id;
            training.Individual = workingViewModel.Individual;
            training.Remote = workingViewModel.Remote;
            training.CreatedAt = workingViewModel.CreatedAt;
            training.UpdatedAt = workingViewModel.UpdatedAt;
            return training;
        }

        protected override TrainingViewModel CreateNewViewModel(Training entity)
        {
            TrainingViewModel trainingVM = new TrainingViewModel();
            trainingVM.Name = entity.Name;
            trainingVM.StartDate = entity.StartDate;
            trainingVM.EndDate = entity.EndDate;
            trainingVM.TrainingStatus = entity.TrainingStatus;
            trainingVM.ClientId = entity.ClientId;
            trainingVM.ClientName = entity.Client.Name;
            trainingVM.Individual = entity.Individual;
            trainingVM.Remote = entity.Remote;
            trainingVM.Id = entity.Id;
            trainingVM.CreatedAt = entity.CreatedAt;
            trainingVM.UpdatedAt = entity.UpdatedAt;
            return trainingVM;
        }

        protected override Training EditEntityByViewModel(Training entity, TrainingViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            entity.StartDate = workingViewModel.StartDate;
            entity.EndDate = workingViewModel.EndDate;
            entity.TrainingStatus = workingViewModel.TrainingStatus;
            entity.ClientId = workingViewModel.ClientId;
            entity.Individual = workingViewModel.Individual;
            entity.Remote = workingViewModel.Remote;
            return entity;
        }
    }
}
