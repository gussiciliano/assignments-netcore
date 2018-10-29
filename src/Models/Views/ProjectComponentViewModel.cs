using System;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectComponentViewModel : BaseEntityViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        // public virtual Project Project { get; set; }
        // public virtual Tech Tech { get; set; }
        // public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
