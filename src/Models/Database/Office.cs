namespace AssignmentsNetcore.Models.Database
{

    public class Office : BaseEntity
    {
        public Country Country { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
    }
}
