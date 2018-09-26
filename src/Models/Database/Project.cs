using System;

namespace AssignmentsNetcore.Models.Database
{

    public class Project : BaseEntity
    {
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public Tech Tech { get; set; }
        public Client Client { get; set; }
    }
}
