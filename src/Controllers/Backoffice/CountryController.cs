using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    public class CountryController : CRUDController<Country, CountryViewModel>
    {
        public CountryController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<Country> WorkingRepository { get { return UnitOfWork.CountryRepository; } }

        public override IActionResult Index()
        {
            var countries = WorkingRepository.GetAll();
            return View(countries.Select(c => CreateNewViewModel(c)).ToList());
        }

        public override IActionResult Create()
        {
            var countryViewModel = new CountryViewModel();
            return View(countryViewModel);
        }
        public override IActionResult Edit(int? id)
        {
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var countryViewModel = CreateNewViewModel(workingEntity);
            return View(countryViewModel);
        }
        protected override Country CreateNewEntity(CountryViewModel workingViewModel)
        {
            Country country = new Country();
            country.Name = workingViewModel.Name;
            return country;
        }
        protected override CountryViewModel CreateNewViewModel(Country entity)
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.Id = entity.Id;
            countryViewModel.Name = entity.Name;
            return countryViewModel;
        }

        protected override Country EditEntityByViewModel(Country entity, CountryViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            return entity;
        }
    }
}
