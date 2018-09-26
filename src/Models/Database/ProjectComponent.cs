using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class ProjectComponent : BaseEntity
    {
        public ICollection<Assignment> Assignments { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Project Project { get; set; }
        public ProjectStatus Status { get; set; }
        public virtual Tech Tech { get; set; }
    }
}
