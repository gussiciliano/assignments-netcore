using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectComponentFormViewModel : ProjectComponentViewModel
    {
        public ProjectComponentFormViewModel()
        {
            this.Projects = new List<SelectListItem>();
            this.Statuses = new List<SelectListItem>();
        }
        public ProjectComponentFormViewModel(IEnumerable<Tech> techs, IEnumerable<Project> projects) : base()
        {
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public ProjectComponentFormViewModel(ProjectComponent projectComponent, IEnumerable<Tech> techs, IEnumerable<Project> projects) : base(projectComponent)
        {
            this.Project = new ProjectViewModel(projectComponent.Project);
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        [Required]
        public IEnumerable<SelectListItem> Techs { get; set; }
        [Required]
        public IEnumerable<SelectListItem> Projects { get; set; }
        [Required]
        public IEnumerable<SelectListItem> Statuses { get; set; }
    }
}
