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

        public ProjectFormViewModel(IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents)
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectComponents = projectComponents.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
        }

        public ProjectFormViewModel(IEnumerable<Client> clients) =>
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));

        public ProjectFormViewModel(Project project, IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base(project)
        {
            this.Name = project.Name;
            this.StartDate = project.StartDate;
            this.EndDate = project.EndDate;
            this.ClientId = project.ClientId;
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectComponents = projectComponents.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        public IEnumerable<SelectListItem> Clients { get; set; }
        public IEnumerable<SelectListItem> ProjectComponents { get; set; }
    }
}
