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
        protected override Person CreateNewEntity(PersonViewModel workingViewModel) => new Person(workingViewModel);
        protected override PersonViewModel CreateNewViewModel(Person entity) => new PersonViewModel(entity);

        protected override Person EditEntityByViewModel(Person entity, PersonViewModel workingViewModel)
        {
            entity.Update(workingViewModel);
            return entity;
        }
    }
}
