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
    public class CommercialController : CRUDController<Commercial, CommercialViewModel>
    {
        public CommercialController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Commercial> WorkingRepository => throw new NotImplementedException();

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
