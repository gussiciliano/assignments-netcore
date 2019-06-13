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
        }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ClientViewModel Client { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
    }
}
