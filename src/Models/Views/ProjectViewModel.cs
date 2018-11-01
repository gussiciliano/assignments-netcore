using System;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectViewModel : BaseEntityViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        // public virtual Client Client { get; set; }
        // public virtual ICollection<ProjectComponent> ProjectComponents { get; set; }
    }
}
