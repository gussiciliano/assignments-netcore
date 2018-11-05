using System;
using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{
    public class PersonJobRole : BaseEntity
    {
        public bool Active { get; set; }
        public virtual Person Person { get; set; }
        public virtual JobRole JobRole { get; set; }
    }
}
