using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class CommercialController : CRUDController<Commercial, CommercialViewModel>
    {
        public CommercialController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Commercial> WorkingRepository { get { return UnitOfWork.CommercialRepository; } }

        protected override Commercial CreateNewEntity(CommercialViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override CommercialViewModel CreateNewViewModel(Commercial entity)
        {
            throw new NotImplementedException();
        }

        protected override Commercial EditEntityByViewModel(Commercial entity, CommercialViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
