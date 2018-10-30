using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class TrainingController : CRUDController<Training, TrainingViewModel>
    {
        public TrainingController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Training> WorkingRepository => throw new NotImplementedException();

        protected override Training CreateNewEntity(TrainingViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override TrainingViewModel CreateNewViewModel(Training entity)
        {
            throw new NotImplementedException();
        }

        protected override Training EditEntityByViewModel(Training entity, TrainingViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
