using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class ProjectViewModel : BaseEntityViewModel
    {

        public ProjectViewModel(Project project) : base()
        {
            this.Name = project.Name;
            this.StartDate = project.StartDate;
            this.EndDate = project.EndDate;
            this.ClientId = project.ClientId;
            this.ClientName = project.Client.Name;
        }

        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}
