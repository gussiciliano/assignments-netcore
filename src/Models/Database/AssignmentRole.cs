using System;

namespace AssignmentsNetcore.Models.Database
{

    public class AssignmentRole : BaseEntity
    {
        public Role Role { get; set; }
        public Assignment Assignment { get; set; }
    }
}
