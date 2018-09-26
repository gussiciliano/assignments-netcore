using System;

namespace AssignmentsNetcore.Models.Database
{   

    public class Changes : BaseEntity {
        public String TableName { get; set; }
        public String ColumnName { get; set; }
        public String PreviousValue { get; set; }
        public String NewValue { get; set; }
        public virtual User User { get; set; } 
    }
}
