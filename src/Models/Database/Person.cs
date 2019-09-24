using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Person : BaseEntity
    {
        public Person() : base()
        {
            this.Assignments = new List<Assignment>();
            this.Techs = new List<PersonTech>();
        }

        public Person(PersonFormViewModel personFormViewModel) : base()
        {
            this.Name = personFormViewModel.Name;
            this.Surname = personFormViewModel.Surname;
            this.Mail = personFormViewModel.Mail;
            this.EntryDate = personFormViewModel.EntryDate;
            this.Workload = personFormViewModel.Workload;
            this.Active = personFormViewModel.Active;
            this.OfficeId = personFormViewModel.OfficeId;
            this.Assignments = new List<Assignment>();
            this.Techs = new List<PersonTech>();
            personFormViewModel.DevTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.Developer }));
            personFormViewModel.LDTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.LeadDeveloper }));
            personFormViewModel.TLTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.TechnicalLeader }));
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [NotMapped]
        public string CompleteName => Name + " " + Surname;
        [Required]
        public string Mail { get; set; }
        public DateTime EntryDate { get; set; }
        public int Workload { get; set; }
        public bool Active { get; set; }
        [Required]
        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<PersonTech> Techs { get; set; }

        public void Update(PersonFormViewModel person)
        {
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.Mail = person.Mail;
            this.EntryDate = person.EntryDate;
            this.Workload = person.Workload;
            this.Active = person.Active;
            this.OfficeId = person.OfficeId;
            this.Active = person.Active;
            this.Techs.Clear();
            person.DevTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.Developer }));
            person.LDTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.LeadDeveloper }));
            person.TLTechIds.ToList().ForEach(id => this.Techs.Add(new PersonTech() { TechId = id, DeveloperRole = DevRole.TechnicalLeader }));
        }

        public string TechsString()
        {
            string ret = "(";
            foreach (var tech in Techs)
            {
                ret += tech.Tech.Name + ", ";
            }
            if (ret.Length < 2)
                ret = string.Empty;
            else
            {
                ret = ret.Remove(ret.Length - 2, 2) + ")";
            }
            return ret;
        }
    }
}
