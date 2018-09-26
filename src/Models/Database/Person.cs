using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Person : BaseEntity
    {
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public Workload Workload { get; set; }
        public Office Office { get; set; }

        public List<JobRole> Roles { get; set; }
        public bool Active { get; set; }
    }
}
