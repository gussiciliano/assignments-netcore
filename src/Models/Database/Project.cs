using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Project : BaseEntity
    {
        public Project() : base() { }

        public Project(ProjectViewModel projectViewModel) : base()
        {
            this.Name = projectViewModel.Name;
            this.StartDate = projectViewModel.StartDate;
            this.EndDate = projectViewModel.EndDate;
            this.ClientId = projectViewModel.Client.Id;
        }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ProjectComponent> ProjectComponents { get; set; }

        public Project Update(ProjectViewModel projectViewModel)
        {
            this.Name = projectViewModel.Name;
            this.StartDate = projectViewModel.StartDate;
            this.EndDate = projectViewModel.EndDate;
            this.ClientId = projectViewModel.Client.Id;
            return this;
        }
    }
}
