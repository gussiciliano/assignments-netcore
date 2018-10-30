using System;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Controllers
{
    public class PersonController : CRUDController<Person, PersonViewModel>
    {
        public PersonController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Person> WorkingRepository { get { return UnitOfWork.PersonRepository; } }

        protected override Person CreateNewEntity(PersonViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }

        protected override PersonViewModel CreateNewViewModel(Person entity)
        {
            throw new NotImplementedException();
        }

        protected override Person EditEntityByViewModel(Person entity, PersonViewModel workingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
