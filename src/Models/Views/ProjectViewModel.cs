using System;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectViewModel : BaseEntityViewModel
    {
        public ProjectViewModel() : base() { }

        public ProjectViewModel(Project project) : base(project)
        {
            this.Name = project.Name;
            this.StartDate = project.StartDate;
            this.EndDate = project.EndDate;
            this.Client = new ClientViewModel(project.Client);
            this.ProjectStatus = Enum.GetName(typeof(ProjectStatus), project.ProjectStatus);
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public ClientViewModel Client { get; set; }
        [Required]
        public string ProjectStatus { get; set; }
    }
}
