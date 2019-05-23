using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Assignment : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        [Required]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public virtual ProjectComponent ProjectComponent { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
