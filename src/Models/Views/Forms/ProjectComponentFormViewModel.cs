using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectComponentFormViewModel : BaseEntityViewModel
    {
        public ProjectComponentFormViewModel() : base() { }
        public ProjectComponentFormViewModel(IEnumerable<Tech> techs, IEnumerable<Project> projects) : base()
        {
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public ProjectComponentFormViewModel(ProjectComponent projectComponent, IEnumerable<Tech> techs, IEnumerable<Project> projects) : base(projectComponent)
        {
            this.Name = projectComponent.Name;
            this.StartDate = projectComponent.StartDate;
            this.EndDate = projectComponent.EndDate;
            this.Status = projectComponent.Status;
            this.ProjectId = projectComponent.ProjectId;
            this.TechId = projectComponent.TechId;
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public int ProjectId { get; set; }
        public int TechId { get; set; }
        public IEnumerable<SelectListItem> Techs { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }
        public IEnumerable<SelectListItem> Statuses { get; set; }
    }
}
