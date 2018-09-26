using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Assignment : BaseEntity
    {
        public Person Woloxer { get; set; }
        public ProjectComponent Project { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<AssignmentRole> AssignmentRoles { get; set; }
        public List<Feedback> Feedback { get; set; }
        public Workload Workload { get; set; }
    }
}
