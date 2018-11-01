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

        protected override IRepository<Tech> WorkingRepository { get { return UnitOfWork.TechRepository; } }

        protected override Tech CreateNewEntity(TechViewModel workingViewModel)
        {
            Tech tech = new Tech();
            tech.Name = workingViewModel.Name;
            return tech;
        }

        protected override TechViewModel CreateNewViewModel(Tech entity)
        {
            TechViewModel techViewModel = new TechViewModel();
            techViewModel.Id = entity.Id;
            techViewModel.Name = entity.Name;
            techViewModel.CreatedAt = entity.CreatedAt;
            techViewModel.UpdatedAt = entity.UpdatedAt;
            return techViewModel;
        }

        protected override Tech EditEntityByViewModel(Tech entity, TechViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            return entity;
        }
    }
}
