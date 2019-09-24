using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    public class PositionController : CRUDController<Position, PositionViewModel>
    {
        public PositionController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Position> WorkingRepository { get { return UnitOfWork.PositionRepository; } }

        public override IActionResult Index()
        {
            var positions = WorkingRepository.GetAll();
            return View(positions.Select(p => CreateNewViewModel(p)).ToList());
        }

        public override IActionResult Create()
        {
            var positionViewModel = new PositionViewModel();
            return View(positionViewModel);
        }
        public override IActionResult Edit(int? id)
        {
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var positionViewModel = CreateNewViewModel(workingEntity);
            return View(positionViewModel);
        }
        protected override Position CreateNewEntity(PositionViewModel workingViewModel)
        {
            Position position = new Position();
            position.Name = workingViewModel.Name;
            return position;
        }
        protected override PositionViewModel CreateNewViewModel(Position entity)
        {
            PositionViewModel positionViewModel = new PositionViewModel(entity);
            return positionViewModel;
        }

        protected override Position EditEntityByViewModel(Position entity, PositionViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            return entity;
        }
    }
}
