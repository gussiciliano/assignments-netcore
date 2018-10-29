using System;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class PersonViewModel : BaseEntityViewModel
    {
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        // public virtual Office Office { get; set; }
        // public virtual ICollection<JobRole> JobRoles { get; set; }
    }
}
