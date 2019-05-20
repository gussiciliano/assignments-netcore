using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ClientViewModel : BaseEntityViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
