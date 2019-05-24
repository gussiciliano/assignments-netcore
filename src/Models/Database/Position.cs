using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class Position : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Assignment> Assigments { get; set; }
    }
}
