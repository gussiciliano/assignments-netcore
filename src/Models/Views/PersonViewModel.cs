using System;
using System.Collections.Generic;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class PersonViewModel : BaseEntityViewModel
    {
        public PersonViewModel() { }

        public PersonViewModel(Person person)
        {
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.CompleteName = person.Name + " " + person.Surname;
            this.Mail = person.Mail;
            this.EntryDate = person.EntryDate;
            this.Workload = person.Workload;
            this.Active = person.Active;
            this.OfficeId = person.OfficeId;
            this.Office = person.Office != null ? new OfficeViewModel(person.Office) : null;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompleteName { get; set; }
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        public int OfficeId { get; set; }
        public OfficeViewModel Office { get; set; }
        public ICollection<SelectListItem> Offices { get; set; }
        public ICollection<AssignmentViewModel> Assigments { get; set; }
    }
}
