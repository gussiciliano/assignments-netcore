using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{
    public class Assignment : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        public virtual Person Person { get; set; }
        public virtual ProjectComponent ProjectComponent { get; set; }
        public virtual ICollection<AssignmentRole> AssignmentRoles { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
