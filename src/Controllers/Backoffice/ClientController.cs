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
            Client client = new Client();
            client.Name = workingViewModel.Name;
            return client;
        }

        protected override ClientViewModel CreateNewViewModel(Client entity) => new ClientViewModel(entity);

        protected override Client EditEntityByViewModel(Client entity, ClientViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            return entity;
        }
    }
}
