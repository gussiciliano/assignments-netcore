using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    public class OfficeController : CRUDController<Office, OfficeViewModel>
    {
        public OfficeController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Office> WorkingRepository { get { return UnitOfWork.OfficeRepository; } }

        public override IActionResult Create() => View(new OfficeFormViewModel(UnitOfWork.CountryRepository.GetAll()));

        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new OfficeFormViewModel(workingEntity, UnitOfWork.CountryRepository.GetAll()));
        }

        protected override Office CreateNewEntity(OfficeViewModel workingViewModel)
        {
            Office office = new Office();
            office.CountryId = workingViewModel.Country.Id;
            office.Name = workingViewModel.Name;
            office.Active = workingViewModel.Active;
            office.Address = workingViewModel.Address;
            return office;
        }

        protected override OfficeViewModel CreateNewViewModel(Office entity)
        {
            OfficeViewModel officeViewModelOffice = new OfficeViewModel();
            officeViewModelOffice.Id = entity.Id;
            officeViewModelOffice.Country = new CountryViewModel(entity.Country);
            officeViewModelOffice.Name = entity.Name;
            officeViewModelOffice.Active = entity.Active;
            officeViewModelOffice.Address = entity.Address;
            officeViewModelOffice.CreatedAt = entity.CreatedAt;
            officeViewModelOffice.UpdatedAt = entity.UpdatedAt;
            return officeViewModelOffice;
        }

        protected override Office EditEntityByViewModel(Office entity, OfficeViewModel workingViewModel)
        {
            entity.CountryId = workingViewModel.Country.Id;
            entity.Name = workingViewModel.Name;
            entity.Active = workingViewModel.Active;
            entity.Address = workingViewModel.Address;
            return entity;
        }
    }
}
