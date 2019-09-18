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

        public TrainingFormViewModel(IEnumerable<Tech> techs, IEnumerable<Tab> tabs) : base()
        {
            this.Techs = techs.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
            this.Tabs = tabs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public TrainingFormViewModel(Training training, IEnumerable<Tech> techs, IEnumerable<Tab> tabs) : base(training)
        {
            this.Name = training.Name;
            this.StartDate = training.StartDate;
            this.EndDate = training.EndDate;
            this.TabId = training.TabId;
            this.Tabs = tabs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Techs = techs.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
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
        public int TabId { get; set; }
        public int TechId { get; set; }
        public bool Individual { get; set; }
        public bool Remote { get; set; }
        [Required]
        public TrainingStatus TrainingStatus { get; set; }
        public bool Active { get; set; }
        public IEnumerable<SelectListItem> Tabs { get; set; }
        public IEnumerable<SelectListItem> Techs { get; set; }
    }
}
