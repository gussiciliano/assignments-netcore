using System;

namespace AssignmentsNetcore.Models.Database
{

    public class Project : BaseEntity
    {
        public Client Client { get; set; }
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ProjectComponent> Components { get; set; }
        public Status Status { get; set; }
        public Tech Tech { get; set; }
    }
}
