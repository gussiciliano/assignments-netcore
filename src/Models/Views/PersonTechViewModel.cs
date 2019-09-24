using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class PersonTechViewModel : BaseEntityViewModel
    {
        public PersonTechViewModel() { }

        public PersonTechViewModel(PersonTech personTech)
        {
            this.Name = personTech.Person.Name;
            this.Surname = personTech.Person.Surname;
            this.CompleteName = Name + " " + Surname;
            this.Mail = personTech.Person.Mail;
            this.TechName = personTech.Tech.Name;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompleteName { get; set; }
        public string Mail { get; set; }
        public string TechName { get; set; }
    }
}
