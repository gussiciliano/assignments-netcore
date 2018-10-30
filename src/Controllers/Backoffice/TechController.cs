using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class TechController : CRUDController<Tech, TechViewModel>
    {
        public TechController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Tech> WorkingRepository => throw new NotImplementedException();

        protected override Tech CreateNewEntity(TechViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override TechViewModel CreateNewViewModel(Tech entity)
        {
            throw new NotImplementedException();
        }

        protected override Tech EditEntityByViewModel(Tech entity, TechViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
