namespace AssignmentsNetcore.Models.Database
{
    public class Changes : BaseEntity
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public virtual User User { get; set; }
    }
}
