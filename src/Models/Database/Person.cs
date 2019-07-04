using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        [Required]
        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<PersonTech> Techs { get; set; }
    }
}
