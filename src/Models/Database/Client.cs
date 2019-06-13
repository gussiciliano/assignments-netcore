using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}

