using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsNetcore.Controllers.Api.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/v1/[controller]")]
    public abstract class BaseApiController<T> : Controller where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly UserManager<User> _userManager;

        public BaseApiController(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            this._unitOfWork = unitOfWork;
            this._userManager = userManager;
        }

        protected IUnitOfWork UnitOfWork { get { return this._unitOfWork; } }

        protected abstract IRepository<T> WorkingRepository { get; }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var workingModel = WorkingRepository.Get(id);
            return Json(workingModel);
        }
    }
}
