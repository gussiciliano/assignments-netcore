using System;
using System.Collections.Generic;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class AssignmentFormViewModel : BaseEntityViewModel
    {
        public AssignmentFormViewModel() { }

        public AssignmentFormViewModel(IEnumerable<Tech> techs, IEnumerable<Person> persons, IEnumerable<Project> projects, IEnumerable<Position> positions)
        {
            this.Projects = projects.Select(c => new SelectListItem(c.Name + " (" + c.Tech.Name + ")", c.Id.ToString()));
            this.Persons = persons.Select(c => new SelectListItem(c.CompleteName + " " + c.TechsString(), c.Id.ToString()));
            this.Positions = positions.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public AssignmentFormViewModel(Assignment assignment,
                                        IEnumerable<Tech> techs,
                                        IEnumerable<Person> persons,
                                        IEnumerable<Project> projects,
                                        IEnumerable<Position> positions)
        {
            this.Id = assignment.Id;
            this.StartDate = assignment.StartDate;
            this.EndDate = assignment.EndDate;
            this.Workload = assignment.Workload;
            this.PersonId = assignment.PersonId;
            this.PositionId = assignment.PositionId;
            this.ProjectId = assignment.ProjectId;
            this.Person = assignment.Person != null ? new PersonViewModel(assignment.Person) : null;
            this.Position = assignment.Position != null ? new PositionViewModel(assignment.Position) : null;
            this.Project = assignment.Project != null ? new ProjectViewModel(assignment.Project) : null;
            this.Projects = projects.Select(c => new SelectListItem(c.Name + " (" + c.Tech.Name + ")", c.Id.ToString()));
            this.Persons = persons.Select(c => new SelectListItem(c.CompleteName + " " + c.TechsString(), c.Id.ToString()));
            this.Positions = positions.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
            this.Techs = techs.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        public PersonViewModel Person { get; set; }
        public PositionViewModel Position { get; set; }
        public int PersonId { get; set; }
        public int PositionId { get; set; }
        public int ProjectId { get; set; }
        public ProjectViewModel Project { get; set; }
        public IEnumerable<SelectListItem> Persons { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }
        public IEnumerable<SelectListItem> Tabs { get; set; }
        public IEnumerable<SelectListItem> Techs { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }
    }
}
