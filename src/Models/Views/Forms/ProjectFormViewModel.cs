using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectFormViewModel : BaseEntityViewModel
    {
        public ProjectFormViewModel() : base() { }
        public ProjectFormViewModel(IEnumerable<Tech> techs, IEnumerable<Tab> tabs) : base()
        {
            this.Techs = techs.Select(t => new SelectListItem(t.Name, t.Id.ToString()));
            this.Tabs = tabs.Select(t => new SelectListItem(t.Name, t.Id.ToString()));
        }

        public ProjectFormViewModel(Project project, IEnumerable<Tech> techs, IEnumerable<Tab> tabs) : base(project)
        {
            this.Name = project.Name;
            this.StartDate = project.StartDate;
            this.EndDate = project.EndDate;
            this.Status = project.Status;
            this.TabId = project.TabId;
            this.TechId = project.TechId;
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Tabs = tabs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public int TabId { get; set; }
        public int TechId { get; set; }
        public IEnumerable<SelectListItem> Techs { get; set; }
        public IEnumerable<SelectListItem> Tabs { get; set; }
        public IEnumerable<SelectListItem> Statuses { get; set; }
    }
}
