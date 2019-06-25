using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Project : BaseEntity
    {
        public Project() : base() { }

        public Project(ProjectFormViewModel projectFormViewModel) : base()
        {
            this.Name = projectFormViewModel.Name;
            this.StartDate = projectFormViewModel.StartDate;
            this.EndDate = projectFormViewModel.EndDate;
            this.ClientId = projectFormViewModel.ClientId;
            this.ProjectStatus = projectFormViewModel.ProjectStatus;
        }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ProjectComponent> ProjectComponents { get; set; }

        public Project Update(ProjectFormViewModel projectFormViewModel)
        {
            this.Name = projectFormViewModel.Name;
            this.StartDate = projectFormViewModel.StartDate;
            this.EndDate = projectFormViewModel.EndDate;
            this.ClientId = projectFormViewModel.ClientId;
            this.ProjectStatus = projectFormViewModel.ProjectStatus;
            return this;
        }
    }
}
