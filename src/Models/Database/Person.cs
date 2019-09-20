using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Models.Database
{
    public class Person : BaseEntity
    {
        public Person()
        {
            this.Assignments = new List<Assignment>();
            this.Techs = new List<PersonTech>();
        }

        public Person(PersonViewModel personViewModel) : this()
        {
            this.Name = personViewModel.Name;
            this.Surname = personViewModel.Surname;
            this.Mail = personViewModel.Mail;
            this.EntryDate = personViewModel.EntryDate;
            this.Workload = personViewModel.Workload;
            this.Active = personViewModel.Active;
            this.OfficeId = personViewModel.OfficeId;
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

        public void Update(PersonViewModel person)
        {
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.Mail = person.Mail;
            this.EntryDate = person.EntryDate;
            this.Workload = person.Workload;
            this.Active = person.Active;
            this.OfficeId = person.OfficeId;
            this.Active = person.Active;
        }
    }
}
