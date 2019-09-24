using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsNetcore.Controllers
{
    [Route("backoffice/[controller]")]
    public class TabController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TabController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        private IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(UnitOfWork.TabRepository.GetAll().Select(t => new TabViewModel(t)).ToList());

        [HttpGet("Details/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.TabRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new TabViewModel(workingEntity));
        }

        [HttpGet("Create")]
        public IActionResult Create() => View(new TabFormViewModel(UnitOfWork.ClientRepository.GetAll()));

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TabFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(workingViewModel);
            }
            UnitOfWork.TabRepository.Add(new Tab(workingViewModel));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.TabRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new TabFormViewModel(workingEntity, UnitOfWork.ClientRepository.GetAll(), UnitOfWork.ProjectRepository.GetAll()));
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TabFormViewModel workingViewModel)
        {
            if (!ModelState.IsValid)
                return View(workingViewModel);
            Tab tab = UnitOfWork.TabRepository.Get(id);
            tab.Update(workingViewModel);
            UnitOfWork.TabRepository.Update(tab);
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = UnitOfWork.TabRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(new TabViewModel(workingEntity));
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                UnitOfWork.TabRepository.Remove(UnitOfWork.TabRepository.Get(id));
                UnitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }
    }
}
