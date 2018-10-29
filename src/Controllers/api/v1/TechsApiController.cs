using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers
{
    [Route("api/v1/[controller]")]
    public class TechsApiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }
        public TechsApiController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var techs = UnitOfWork.TechsRepository.GetAll().Select(tech =>  new Tech { Name = tech.Name }).ToList();
            return View(techs);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(TechViewModel tvm)
        {
            if (ModelState.IsValid)
            {
                var tech = new Tech { Name = tvm.Name };
                UnitOfWork.TechsRepository.Add(tech);
                UnitOfWork.Complete();
            }
            return RedirectToAction("Index", "Techs");
        }
    }
}