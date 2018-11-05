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
    public class PersonController : CRUDController<Person, PersonViewModel>
    {
        public PersonController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Person> WorkingRepository { get { return UnitOfWork.PersonRepository; } }
        public override IActionResult Create()
        {
            var personViewModel = new PersonViewModel();
            personViewModel.Offices = UnitOfWork.OfficeRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(personViewModel);
        }
        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var personViewModel = CreateNewViewModel(workingEntity);
            personViewModel.Offices = UnitOfWork.OfficeRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(personViewModel);
        }
        protected override Person CreateNewEntity(PersonViewModel workingViewModel)
        {
            Person person = new Person();
            person.Mail = workingViewModel.Mail;
            person.EntryDate = workingViewModel.EntryDate;
            person.Workload = workingViewModel.Workload;
            person.Active = workingViewModel.Active;
            person.OfficeId = workingViewModel.OfficeId;
            // TODO: send this from the view
            // person.JobRoles = workingViewModel.JobRoles;
            return person;
        }
        protected override PersonViewModel CreateNewViewModel(Person entity)
        {
            PersonViewModel personViewModel = new PersonViewModel();
            personViewModel.Id = entity.Id;
            personViewModel.Mail = entity.Mail;
            personViewModel.EntryDate = entity.EntryDate;
            personViewModel.Workload = entity.Workload;
            personViewModel.Active = entity.Active;
            personViewModel.OfficeId = entity.OfficeId;
            // TODO: send this from the view
            // personViewModel.JobRoles = entity.JobRoles;
            personViewModel.CreatedAt = entity.CreatedAt;
            personViewModel.UpdatedAt = entity.UpdatedAt;
            return personViewModel;
        }
        protected override Person EditEntityByViewModel(Person entity, PersonViewModel workingViewModel)
        {
            entity.Mail = workingViewModel.Mail;
            entity.EntryDate = workingViewModel.EntryDate;
            entity.Workload = workingViewModel.Workload;
            entity.Active = workingViewModel.Active;
            entity.OfficeId = workingViewModel.OfficeId;
            // TODO: send this from the view
            // entity.JobRoles = workingViewModel.JobRoles;
            return entity;
        }
    }
}
