using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
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
