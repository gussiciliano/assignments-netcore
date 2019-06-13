using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Training : Project
    {
        public Training() : base() { }

        public Training(TrainingViewModel trainingViewModel) : base(trainingViewModel)
        {
            this.Individual = trainingViewModel.Individual;
            this.Remote = trainingViewModel.Remote;
            this.TrainingStatus = trainingViewModel.TrainingStatus;
        }

        public bool Individual { get; set; }
        public bool Remote { get; set; }
        public TrainingStatus TrainingStatus { get; set; }

        public Training Update(TrainingViewModel trainingViewModel)
        {
            this.Name = trainingViewModel.Name;
            this.StartDate = trainingViewModel.StartDate;
            this.EndDate = trainingViewModel.EndDate;
            this.ClientId = trainingViewModel.Client.Id;
            this.Individual = trainingViewModel.Individual;
            this.Remote = trainingViewModel.Remote;
            this.TrainingStatus = trainingViewModel.TrainingStatus;
            return this;
        }
    }
}
