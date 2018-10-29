using System;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class AssignmentViewModel : BaseEntityViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        // public virtual Person Person { get; set; }
        // public virtual ProjectComponent ProjectComponent { get; set; }
        // public virtual ICollection<AssignmentRole> AssignmentRoles { get; set; }
        // public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
