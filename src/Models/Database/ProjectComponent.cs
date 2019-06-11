using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class ProjectComponent : BaseEntity
    {
        public ProjectComponent(ProjectComponentViewModel projectComponentViewModel) : base()
        {
            this.StartDate = projectComponentViewModel.StartDate;
            this.EndDate = projectComponentViewModel.EndDate;
            this.Status = projectComponentViewModel.Status;
            this.ProjectId = projectComponentViewModel.Project.Id;
            this.TechId = projectComponentViewModel.Tech.Id;
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        [Required]
        public int TechId { get; set; }
        public virtual Tech Tech { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
