using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class OfficeController : CRUDController<Office, OfficeViewModel>
    {
        public OfficeController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Office> WorkingRepository { get { return UnitOfWork.OfficeRepository; } }

        protected override Office CreateNewEntity(OfficeViewModel workingViewModel)
        {
            Office office = new Office();
            office.Country = workingViewModel.Country;
            office.Name = workingViewModel.Name;
            office.Active = workingViewModel.Active;
            office.Address = workingViewModel.Address;
            return office;
        }

        protected override OfficeViewModel CreateNewViewModel(Office entity)
        {
            OfficeViewModel officeViewModelOffice = new OfficeViewModel();
            officeViewModelOffice.Id = entity.Id;
            officeViewModelOffice.Country = entity.Country;
            officeViewModelOffice.Name = entity.Name;
            officeViewModelOffice.Active = entity.Active;
            officeViewModelOffice.Address = entity.Address;
            officeViewModelOffice.CreatedAt = entity.CreatedAt;
            officeViewModelOffice.UpdatedAt = entity.UpdatedAt;
            return officeViewModelOffice;
        }

        protected override Office EditEntityByViewModel(Office entity, OfficeViewModel workingViewModel)
        {
            entity.Country = workingViewModel.Country;
            entity.Name = workingViewModel.Name;
            entity.Active = workingViewModel.Active;
            entity.Address = workingViewModel.Address;
            return entity;
        }
    }
}
