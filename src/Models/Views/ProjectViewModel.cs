using System;
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
            this.Status = project.Status;
            this.TabName = project.Tab.Name;
            this.Tech = new TechViewModel(project.Tech);
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public string TabName { get; set; }
        public TechViewModel Tech { get; set; }
    }
}
