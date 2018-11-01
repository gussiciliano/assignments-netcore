using System;
using System.Collections.Generic;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class PersonViewModel : BaseEntityViewModel
    {
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public ICollection<SelectListItem> Offices { get; set; }
        public ICollection<JobRole> JobRoles { get; set; }
    }
}
