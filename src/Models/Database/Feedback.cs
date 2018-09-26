namespace AssignmentsNetcore.Models.Database
{

    public class Feedback : BaseEntity
    {
        public virtual Assignment Assignment { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Person Reviewer { get; set; }
    }
}
