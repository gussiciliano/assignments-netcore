using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Training : Tab
    {
        public Training() : base() { }

        public Training(TrainingFormViewModel trainingFormViewModel)
        {
            this.Name = trainingFormViewModel.Name;
            this.StartDate = trainingFormViewModel.StartDate;
            this.EndDate = trainingFormViewModel.EndDate;
            this.ClientId = trainingFormViewModel.ClientId;
            this.ProjectStatus = trainingFormViewModel.ProjectStatus;
            this.Individual = trainingFormViewModel.Individual;
            this.Remote = trainingFormViewModel.Remote;
            this.TrainingStatus = trainingFormViewModel.TrainingStatus;
        }

        public bool Individual { get; set; }
        public bool Remote { get; set; }
        public TrainingStatus TrainingStatus { get; set; }

        public Training Update(TrainingFormViewModel trainingFormViewModel)
        {
            this.Name = trainingFormViewModel.Name;
            this.StartDate = trainingFormViewModel.StartDate;
            this.EndDate = trainingFormViewModel.EndDate;
            this.ClientId = trainingFormViewModel.ClientId;
            this.Individual = trainingFormViewModel.Individual;
            this.Remote = trainingFormViewModel.Remote;
            this.TrainingStatus = trainingFormViewModel.TrainingStatus;
            return this;
        }
    }
}
