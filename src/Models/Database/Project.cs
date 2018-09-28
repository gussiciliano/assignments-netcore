using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Project : BaseEntity
    {
        public virtual Client Client { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<ProjectComponent> Components { get; set; }
        public ProjectStatus Status { get; set; }
        public virtual Tech Tech { get; set; }
    }
}
