using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class PersonFormViewModel : BaseEntityViewModel
    {
        public PersonFormViewModel() : base()
        {
            this.DevTechIds = new List<int>();
            this.LDTechIds = new List<int>();
            this.TLTechIds = new List<int>();
        }
        public PersonFormViewModel(IEnumerable<Tech> techs, IEnumerable<Office> offices) : this()
        {
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Offices = offices.Select(o => new SelectListItem(o.Name, o.Id.ToString()));
        }

        public PersonFormViewModel(Person person, IEnumerable<Tech> techs, IEnumerable<Office> offices) : base(person)
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
            this.Id = person.Id;
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Offices = offices.Select(o => new SelectListItem(o.Name, o.Id.ToString()));
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string CompleteName { get; set; }
        [Required]
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        public int OfficeId { get; set; }
        public OfficeViewModel Office { get; set; }
        public IEnumerable<int> DevTechIds { get; set; }
        public IEnumerable<int> LDTechIds { get; set; }
        public IEnumerable<int> TLTechIds { get; set; }
        public IEnumerable<SelectListItem> Techs { get; set; }
        public IEnumerable<SelectListItem> Offices { get; set; }
        public ICollection<AssignmentViewModel> Assigments { get; set; }

        public bool CheckTechs()
        {
            foreach (var devTech in DevTechIds)
            {
                if (LDTechIds.Contains(devTech) || TLTechIds.Contains(devTech))
                    return false;
            }
            foreach (var ldTech in LDTechIds)
            {
                if (TLTechIds.Contains(ldTech))
                    return false;
            }
            return true;
        }
    }
}
