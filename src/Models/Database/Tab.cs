using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Tab : BaseEntity
    {
        public Tab() : base() { }

        public Tab(TabFormViewModel tabFormViewModel) : base()
        {
            this.Name = tabFormViewModel.Name;
            this.StartDate = tabFormViewModel.StartDate;
            this.EndDate = tabFormViewModel.EndDate;
            this.ClientId = tabFormViewModel.ClientId;
            this.Active = tabFormViewModel.Active;
        }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

        public Tab Update(TabFormViewModel tabFormViewModel)
        {
            this.Name = tabFormViewModel.Name;
            this.StartDate = tabFormViewModel.StartDate;
            this.EndDate = tabFormViewModel.EndDate;
            this.ClientId = tabFormViewModel.ClientId;
            this.Active = tabFormViewModel.Active;
            return this;
        }
    }
}
