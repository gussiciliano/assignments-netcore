using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Project : BaseEntity
    {
        public Project() : base()
        {
            this.Assignments = new List<Assignment>();
        }
        public Project(ProjectFormViewModel projectViewModel) : base()
        {
            this.Name = projectViewModel.Name;
            this.StartDate = projectViewModel.StartDate;
            this.EndDate = projectViewModel.EndDate;
            this.Status = projectViewModel.Status;
            this.TabId = projectViewModel.TabId;
            this.TechId = projectViewModel.TechId;
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        [Required]
        public int TabId { get; set; }
        public virtual Tab Tab { get; set; }
        [Required]
        public int TechId { get; set; }
        public virtual Tech Tech { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public Project Update(ProjectFormViewModel projectViewModel)
        {
            this.Name = Name;
            this.StartDate = projectViewModel.StartDate;
            this.EndDate = projectViewModel.EndDate;
            this.Status = projectViewModel.Status;
            this.TabId = projectViewModel.TabId;
            this.TechId = projectViewModel.TechId;
            return this;
        }
    }
}
