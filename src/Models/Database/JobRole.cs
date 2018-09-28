namespace AssignmentsNetcore.Models.Database
{
    public class JobRole : BaseEntity
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual Tech Tech { get; set; }
    }
}
