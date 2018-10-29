using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{
    public class ProjectComponent : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public virtual Project Project { get; set; }
        public virtual Tech Tech { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
