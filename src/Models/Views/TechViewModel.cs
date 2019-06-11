using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class TechViewModel : BaseEntityViewModel
    {
        public TechViewModel(Tech tech) : base()
        {
            this.Name = tech.Name;
        }

        [Required]
        public string Name { get; set; }
    }
}
