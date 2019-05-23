using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class Project : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ProjectComponent> ProjectComponents { get; set; }
    }
}
