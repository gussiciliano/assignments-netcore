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
    public class PersonController : CRUDController<Person, PersonViewModel>
    {
        public PersonController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Person> WorkingRepository => throw new NotImplementedException();

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
