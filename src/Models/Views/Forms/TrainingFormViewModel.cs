using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class TrainingFormViewModel : ProjectFormViewModel
    {
        public TrainingFormViewModel(IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base(clients, projectComponents) { }

        public TrainingFormViewModel(Training training, IEnumerable<Client> clients, IEnumerable<ProjectComponent> projectComponents) : base(training, clients, projectComponents)
        {
            this.Individual = training.Individual;
            this.Remote = training.Remote;
            this.TrainingStatus = training.TrainingStatus;
        }

        public bool Individual { get; set; }
        public bool Remote { get; set; }
        [Required]
        public TrainingStatus TrainingStatus { get; set; }
    }
}
