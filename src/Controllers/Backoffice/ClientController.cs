using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class ClientController : CRUDController<Client, ClientViewModel>
    {
        public ClientController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Client> WorkingRepository { get { return UnitOfWork.ClientRepository; } }

        protected override Client CreateNewEntity(ClientViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override ClientViewModel CreateNewViewModel(Client entity)
        {
            throw new NotImplementedException();
        }

        protected override Client EditEntityByViewModel(Client entity, ClientViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
