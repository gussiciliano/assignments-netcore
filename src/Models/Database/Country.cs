using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class Country : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
