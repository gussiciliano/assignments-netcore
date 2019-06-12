using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class TrainingViewModel : ProjectViewModel
    {
        public TrainingViewModel() : base() {}

        public TrainingViewModel(Training training) : base(training)
        {
            this.Individual = training.Individual;
            this.Remote = training.Remote;
            this.TrainingStatus = training.TrainingStatus;
        }

        public bool Individual { get; set; }
        public bool Remote { get; set; }
        [Required]
        public TrainingStatus TrainingStatus { get; set; }
    }
}
