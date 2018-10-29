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
