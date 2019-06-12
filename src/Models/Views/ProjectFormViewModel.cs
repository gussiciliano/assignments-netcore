using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectFormViewModel : ProjectViewModel
    {
        public ProjectFormViewModel(IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base()
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            //this.Statuses
        }

        public ProjectFormViewModel(Project project, IEnumerable<Client> clients,IEnumerable<ProjectComponent> projectComponents) : base(project)
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectComponents = projectComponents.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
            //this.Projects = projects.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        [Required]
        public IEnumerable<SelectListItem> Clients { get; set; }
        [Required]
        public IEnumerable<SelectListItem> ProjectComponents { get; set; }
        [Required]
        public IEnumerable<SelectListItem> Statuses { get; set; }
    }
}
