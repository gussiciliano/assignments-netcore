using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class TrainingViewModel : ProjectViewModel
    {
        public bool Individual { get; set; }
        public bool Remote { get; set; }
        [Required]
        public TrainingStatus TrainingStatus { get; set; }
    }
}
