using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectFormViewModel : ProjectViewModel
    {
        public ProjectFormViewModel(IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base()
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectStatuses = Enum.GetNames(typeof(ProjectStatus)).Select(e => new SelectListItem() { Text = e, Value = e });
        }

        public ProjectFormViewModel(IEnumerable<Client> clients) : base()
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectStatuses = Enum.GetNames(typeof(ProjectStatus)).Select(e => new SelectListItem() { Text = e, Value = e });
        }

        public ProjectFormViewModel(Project project, IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base(project)
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectComponents = projectComponents.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
            this.ProjectStatuses = Enum.GetNames(typeof(ProjectStatus)).Select(e => new SelectListItem() { Text = e, Value = e });
        }

        [Required]
        public IEnumerable<SelectListItem> Clients { get; set; }
        [Required]
        public IEnumerable<SelectListItem> ProjectComponents { get; set; }
        [Required]
        public IEnumerable<SelectListItem> ProjectStatuses { get; set; }
    }
}
