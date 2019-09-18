using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class TabFormViewModel : BaseEntityViewModel
    {
        public TabFormViewModel() : base() { }

        public TabFormViewModel(IEnumerable<Client> clients, IEnumerable<Project> projects)
        {
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
        }

        public TabFormViewModel(IEnumerable<Client> clients) =>
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));

        public TabFormViewModel(Tab tab, IEnumerable<Client> clients, IEnumerable<Project> projects) : base(tab)
        {
            this.Name = tab.Name;
            this.StartDate = tab.StartDate;
            this.EndDate = tab.EndDate;
            this.ClientId = tab.ClientId;
            this.Clients = clients.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Projects = projects.Select(pc => new SelectListItem(pc.Name, pc.Id.ToString()));
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public bool Active { get; set; }
        public IEnumerable<SelectListItem> Clients { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }
    }
}
