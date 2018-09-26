using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Person : BaseEntity
    {
        public String Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public Workload Workload { get; set; }
        public Office Office { get; set; }

        public List<Role> Roles { get; set; }
        public Boolean Active { get; set; }
    }
}
