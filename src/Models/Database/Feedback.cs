using System;

namespace AssignmentsNetcore.Models.Database
{

    public class Feedback : BaseEntity
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public Person Reviewer { get; set; }
    }
}
