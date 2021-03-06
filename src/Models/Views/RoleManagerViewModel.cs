using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class RoleManagerViewModel
    {
        public List<SelectListItem> UsersListItem { get; set; }
        public Dictionary<string, bool> Roles { get; set; }
        public string SelectedUserId { get; set; }
    }
}
