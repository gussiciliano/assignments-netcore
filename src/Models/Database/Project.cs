using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{

    public class Project : BaseEntity
    {
        public Client Client { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ProjectComponent> Components { get; set; }
        public ProjectStatus Status { get; set; }
        public Tech Tech { get; set; }
    }
}
