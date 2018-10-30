using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class AssignmentController : CRUDController<Assignment, AssignmentViewModel>
    {
        public AssignmentController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Assignment> WorkingRepository { get { return UnitOfWork.AssignmentRepository; } }

        protected override Assignment CreateNewEntity(AssignmentViewModel vm)
        {
            throw new NotImplementedException();
        }

        protected override AssignmentViewModel CreateNewViewModel(Assignment entity)
        {
            throw new NotImplementedException();
        }

        protected override Assignment EditEntityByViewModel(Assignment entity, AssignmentViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
