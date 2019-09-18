using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    [Route("backoffice/[controller]")]
    public class TrainingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrainingController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        private IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(UnitOfWork.TrainingRepository.GetAll().Select(t => new TrainingViewModel(t)).ToList());

        [HttpGet("Details")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            Training training = UnitOfWork.TrainingRepository.Get(id.Value);
            if (training == null) return NotFound();
            return View(new TrainingViewModel(training));
        }

        [HttpGet("Create")]
        public IActionResult Create() => View(new TrainingFormViewModel(UnitOfWork.TechRepository.GetAll(), UnitOfWork.TabRepository.GetAll()));

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TrainingFormViewModel trainingFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(trainingFormViewModel);
            }
            UnitOfWork.TrainingRepository.Add(new Training(trainingFormViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.TrainingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new TrainingFormViewModel(workingEntity, UnitOfWork.TechRepository.GetAll(), UnitOfWork.TabRepository.GetAll()));
        }

        [HttpPost("Edit/{id}")]
        public IActionResult Edit(int id, TrainingFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
                return View(workingViewModel);
            var training = UnitOfWork.TrainingRepository.Get(id);
            training.Update(workingViewModel);
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.TrainingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new TrainingViewModel(workingEntity));
        }

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            UnitOfWork.TrainingRepository.Remove(UnitOfWork.TrainingRepository.Get(id));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
