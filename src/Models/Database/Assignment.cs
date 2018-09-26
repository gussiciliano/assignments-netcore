using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Assignment : BaseEntity
    {
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public Workload Workload { get; set; }
        public virtual Person Person { get; set; }
        public virtual ProjectComponent ProjectComponent { get; set; }
        public virtual ICollection<AssignmentRole> AssignmentRoles { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
