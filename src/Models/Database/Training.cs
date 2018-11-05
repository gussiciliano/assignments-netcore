namespace AssignmentsNetcore.Models.Database
{
    public class Training : Project
    {
        public bool Individual { get; set; }
        public bool Remote { get; set; }
        public TrainingStatus TrainingStatus { get; set; }
    }
}
