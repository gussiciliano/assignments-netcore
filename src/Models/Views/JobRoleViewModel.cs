using System.Collections.Generic;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class JobRoleViewModel : BaseEntityViewModel
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public JobRoleType JobRoleType { get; set; }
        public int TechId { get; set; }
        public string TechName { get; set; }
        public ICollection<SelectListItem> Techs { get; set; }
    }
}
