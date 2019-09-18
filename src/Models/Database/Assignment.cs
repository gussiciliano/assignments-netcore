using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Assignment : BaseEntity
    {
        public Assignment() { }

        public Assignment(AssignmentViewModel viewModel)
        {
            this.StartDate = viewModel.StartDate;
            this.EndDate = viewModel.EndDate;
            this.Workload = viewModel.Workload;
            this.PersonTechId = viewModel.PersonTechId;
            this.PositionId = viewModel.PositionId;
            this.ProjectId = viewModel.ProjectId;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        [Required]
        public int PersonTechId { get; set; }
        public virtual PersonTech PersonTech { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public void Update(AssignmentViewModel viewModel)
        {
            this.StartDate = viewModel.StartDate;
            this.EndDate = viewModel.EndDate;
            this.Workload = viewModel.Workload;
            this.PersonTechId = viewModel.PersonTechId;
            this.PositionId = viewModel.PositionId;
        }
    }
}
