using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class ClientController : CRUDController<Client, ClientViewModel>
    {
        public ClientController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Client> WorkingRepository => throw new NotImplementedException();

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
