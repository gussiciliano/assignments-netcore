using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Database
{
    public class Tech : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<PersonTech> Persons { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
