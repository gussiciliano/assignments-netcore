using System;

namespace AssignmentsNetcore.Models.Database
{

    public class Office : BaseEntity
    {
        public Country Country { get; set; }
        public String Name { get; set; }
        public Boolean Active { get; set; }
        public String Address { get; set; }
    }
}
