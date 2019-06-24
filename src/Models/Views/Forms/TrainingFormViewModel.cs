using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class TrainingFormViewModel : BaseEntityViewModel
    {
        public TrainingFormViewModel() : base() { }

        public TrainingFormViewModel(IEnumerable<Client> clients) : base()
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public TrainingFormViewModel(Training training, IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base(training)
        {
            this.Name = training.Name;
            this.StartDate = training.StartDate;
            this.EndDate = training.EndDate;
            this.ClientId = training.ClientId;
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.ProjectComponents = projectComponents.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
            this.Individual = training.Individual;
            this.Remote = training.Remote;
            this.TrainingStatus = training.TrainingStatus;
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int ClientId { get; set; }

        public bool Individual { get; set; }
        public bool Remote { get; set; }
        [Required]
        public TrainingStatus TrainingStatus { get; set; }
        [Required]
        public ProjectStatus ProjectStatus { get; set; }
        public IEnumerable<SelectListItem> Clients { get; set; }
        public IEnumerable<SelectListItem> ProjectComponents { get; set; }
    }
}
