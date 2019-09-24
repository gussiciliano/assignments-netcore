using System.ComponentModel.DataAnnotations;

namespace AssignmentsNetcore.Models.Database
{
    public class PersonTech
    {
        public int PersonId { get; set; }
        public int TechId { get; set; }
        [Key]
        public DevRole DeveloperRole { get; set; }
        public virtual Person Person { get; set; }
        public virtual Tech Tech { get; set; }
    }
}
