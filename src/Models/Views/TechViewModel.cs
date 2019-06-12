using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class TechViewModel : BaseEntityViewModel
    {
        public TechViewModel() : base() {}
        public TechViewModel(Tech tech) : base(tech)
        {
            this.Name = tech.Name;
        }

        [Required]
        public string Name { get; set; }
    }
}
