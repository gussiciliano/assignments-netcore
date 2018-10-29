using System;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsNetcore.Controllers.Backoffice
{
    [Route("backoffice/[controller]")]
    public abstract class CRUDController<T, TVM> : Controller where T : BaseEntity where TVM : BaseEntityViewModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public CRUDController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        protected abstract IRepository<T> WorkingRepository { get; }

        protected IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        [HttpGet("")]
        public IActionResult Index() => View(WorkingRepository.GetAll().Select(r => CreateNewViewModel(r)).ToList());

        [HttpGet("Details")]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(CreateNewViewModel(workingEntity));
        }

        [HttpGet("Create")]
        public virtual IActionResult Create() => View();

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TVM workingViewModel)
        {
            if (ModelState.IsValid)
            {
                WorkingRepository.Add(CreateNewEntity(workingViewModel));
                UnitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            return View(workingViewModel);
        }

        [HttpGet("Edit/{id}")]
        public virtual IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(CreateNewViewModel(workingEntity));
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TVM workingViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    WorkingRepository.Update(EditEntityByViewModel(WorkingRepository.Get(id), workingViewModel));
                    UnitOfWork.Complete();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(workingViewModel);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            return View(CreateNewViewModel(workingEntity));
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                WorkingRepository.Remove(WorkingRepository.Get(id));
                UnitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }

        protected abstract T CreateNewEntity(TVM workingViewModel);
        protected abstract T EditEntityByViewModel(T entity, TVM workingViewModel);
        protected abstract TVM CreateNewViewModel(T entity);
        private bool WorkingModelExists(int id) => WorkingRepository.Get(id) != null;
    }
}
