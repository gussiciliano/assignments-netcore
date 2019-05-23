using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class Office : BaseEntity
    {
        [Required]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
    }
}
