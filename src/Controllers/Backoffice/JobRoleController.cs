using System;
using System.Linq;
using AssignmentsNetcore.Controllers.Backoffice;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Controllers
{
    public class JobRoleController : CRUDController<JobRole, JobRoleViewModel>
    {
        public JobRoleController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<JobRole> WorkingRepository { get { return UnitOfWork.JobRoleRepository; } }

        public override IActionResult Index()
        {
            var jobRoles = UnitOfWork.JobRoleRepository.GetAllWithTechs();
            return View(jobRoles.Select(r => CreateNewViewModel(r)).ToList());
        }

        public override IActionResult Create()
        {
            var jobRoleViewModel = new JobRoleViewModel();
            jobRoleViewModel.Techs = UnitOfWork.TechRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(jobRoleViewModel);
        }
        public override IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var workingEntity = WorkingRepository.Get(id.Value);
            if (workingEntity == null) return NotFound();
            var jobRoleViewModel = CreateNewViewModel(workingEntity);
            jobRoleViewModel.Techs = UnitOfWork.TechRepository.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return View(jobRoleViewModel);
        }
        protected override JobRole CreateNewEntity(JobRoleViewModel workingViewModel)
        {
            JobRole jobRole = new JobRole();
            jobRole.Name = workingViewModel.Name;
            jobRole.Active = workingViewModel.Active;
            jobRole.JobRoleType = workingViewModel.JobRoleType;
            jobRole.TechId = workingViewModel.TechId;
            return jobRole;
        }
        protected override JobRoleViewModel CreateNewViewModel(JobRole entity)
        {
            JobRoleViewModel jobRoleViewModel = new JobRoleViewModel();
            jobRoleViewModel.Id = entity.Id;
            jobRoleViewModel.Name = entity.Name;
            jobRoleViewModel.Active = entity.Active;
            jobRoleViewModel.JobRoleType = entity.JobRoleType;
            jobRoleViewModel.TechId = entity.TechId;
            jobRoleViewModel.TechName = entity.Tech.Name;
            jobRoleViewModel.CreatedAt = entity.CreatedAt;
            jobRoleViewModel.UpdatedAt = entity.UpdatedAt;
            return jobRoleViewModel;
        }

        protected override JobRole EditEntityByViewModel(JobRole entity, JobRoleViewModel workingViewModel)
        {
            entity.Name = workingViewModel.Name;
            entity.Active = workingViewModel.Active;
            entity.JobRoleType = workingViewModel.JobRoleType;
            entity.TechId = workingViewModel.TechId;
            return entity;
        }
    }
}
