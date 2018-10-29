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
    public class JobRoleController : CRUDController<JobRole, JobRoleViewModel>
    {
        public JobRoleController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<JobRole> WorkingRepository => throw new NotImplementedException();

        protected override JobRole CreateNewEntity(JobRoleViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override JobRoleViewModel CreateNewViewModel(JobRole entity)
        {
            throw new NotImplementedException();
        }

        protected override JobRole EditEntityByViewModel(JobRole entity, JobRoleViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
