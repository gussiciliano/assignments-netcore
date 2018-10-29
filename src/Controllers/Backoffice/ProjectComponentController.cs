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
    public class ProjectComponentController : CRUDController<ProjectComponent, ProjectComponentViewModel>
    {
        public ProjectComponentController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<ProjectComponent> WorkingRepository => throw new NotImplementedException();

        protected override ProjectComponent CreateNewEntity(ProjectComponentViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override ProjectComponentViewModel CreateNewViewModel(ProjectComponent entity)
        {
            throw new NotImplementedException();
        }

        protected override ProjectComponent EditEntityByViewModel(ProjectComponent entity, ProjectComponentViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
