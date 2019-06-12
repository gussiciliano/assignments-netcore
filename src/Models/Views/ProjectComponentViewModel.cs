using System;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectComponentViewModel : BaseEntityViewModel
    {
        public ProjectComponentViewModel() : base() {}

        public ProjectComponentViewModel(ProjectComponent projectComponent) : base(projectComponent)
        {
            this.Name = projectComponent.Name;
            this.StartDate = projectComponent.StartDate;
            this.EndDate = projectComponent.EndDate;
            this.Status = projectComponent.Status;
            this.Project = new ProjectViewModel(projectComponent.Project);
            this.Tech = new TechViewModel(projectComponent.Tech);
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public ProjectViewModel Project { get; set; }
        public TechViewModel Tech { get; set; }
    }
}
