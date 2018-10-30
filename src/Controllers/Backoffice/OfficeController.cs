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
            throw new NotImplementedException();
        }

        protected override OfficeViewModel CreateNewViewModel(Office entity)
        {
            throw new NotImplementedException();
        }

        protected override Office EditEntityByViewModel(Office entity, OfficeViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
