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
        [Required]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public ICollection<SelectListItem> Clients { get; set; }
        // public virtual Client Client { get; set; }
        // public virtual ICollection<ProjectComponent> ProjectComponents { get; set; }
    }
}
