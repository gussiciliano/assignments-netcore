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
    public class AssignmentController : CRUDController<Assignment, AssignmentViewModel>
    {
        public AssignmentController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Assignment> WorkingRepository => throw new NotImplementedException();

        protected override Assignment CreateNewEntity(AssignmentViewModel workingViewModel)
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
