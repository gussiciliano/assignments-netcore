using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Assignment : BaseEntity
    {
        public Assignment() { }

        public Assignment(AssignmentFormViewModel viewModel)
        {
            this.StartDate = viewModel.StartDate;
            this.EndDate = viewModel.EndDate;
            this.Workload = viewModel.Workload;
            this.PersonId = viewModel.PersonId;
            this.PositionId = viewModel.PositionId;
            this.ProjectId = viewModel.ProjectId;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        [Required]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public void Update(AssignmentFormViewModel viewModel)
        {
            this.StartDate = viewModel.StartDate;
            this.EndDate = viewModel.EndDate;
            this.Workload = viewModel.Workload;
            this.PersonId = viewModel.PersonId;
            this.PositionId = viewModel.PositionId;
        }
    }
}
