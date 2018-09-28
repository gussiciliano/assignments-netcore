using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Person : BaseEntity
    {
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<JobRole> JobRoles { get; set; }
        public bool Active { get; set; }
    }
}
