using System;

namespace AssignmentsNetcore.Models.Database
{

    public class AssignmentRole : BaseEntity
    {
        public virtual Assignment Assignment { get; set; }
        public virtual JobRole JobRole { get; set; }
    }
}
