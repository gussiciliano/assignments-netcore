using System;
using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    [Route("backoffice/[controller]")]
    public class PersonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHtmlLocalizer<PersonController> _localizer;
        public PersonController(IUnitOfWork unitOfWork, IHtmlLocalizer<PersonController> localizer)
        {
            this._unitOfWork = unitOfWork;
            this._localizer = localizer;
        }

        public IUnitOfWork UnitOfWork { get => this._unitOfWork; }
        public IHtmlLocalizer<PersonController> Localizer { get => this._localizer; }
        
        [HttpGet("")]
        public IActionResult Index() =>
            View(UnitOfWork.PersonRepository.GetAll().Select(p => new PersonViewModel(p)));
        
        [HttpGet("Create")]
        public IActionResult Create()
        {
            var viewModel = new PersonFormViewModel(UnitOfWork.TechRepository.GetAll(),
                                            UnitOfWork.OfficeRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost("Create")]
        public IActionResult Create(PersonFormViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UnitOfWork.PersonRepository.Add(new Person(viewModel));
                    UnitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(viewModel);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(viewModel);
            }
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var viewModel = new PersonFormViewModel(UnitOfWork.TechRepository.GetAll(),
                                                        UnitOfWork.OfficeRepository.GetAll());
            if (viewModel == null) return NotFound();
            return View(viewModel);
        }

        [HttpPost("Edit/{id}")]
        public IActionResult Edit(int id, PersonFormViewModel personFormViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var person = UnitOfWork.PersonRepository.Get(personFormViewModel.Id);
                    person.Update(personFormViewModel);
                    UnitOfWork.PersonRepository.Update(person);
                    UnitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(personFormViewModel);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(personFormViewModel);
            }
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id) =>
            View(new PersonViewModel(UnitOfWork.PersonRepository.Get(id)));

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var person = UnitOfWork.PersonRepository.Get(id.Value);
            if (person == null) return NotFound();
            return View(new PersonViewModel(person));
        }

        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            UnitOfWork.PersonRepository.Remove(UnitOfWork.PersonRepository.Get(id));
            UnitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
