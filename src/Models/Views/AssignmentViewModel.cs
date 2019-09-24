using System;
using System.Collections.Generic;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentsNetcore.Models.Views
{
    public class AssignmentViewModel : BaseEntityViewModel
    {
        public AssignmentViewModel() { }

        public AssignmentViewModel(Assignment assignment)
        {
            this.Id = assignment.Id;
            this.StartDate = assignment.StartDate;
            this.EndDate = assignment.EndDate;
            this.Workload = assignment.Workload;
            this.PersonId = assignment.PersonId;
            this.PositionId = assignment.PositionId;
            this.ProjectId = assignment.ProjectId;
            this.Person = new PersonViewModel(assignment.Person);
            this.Position = new PositionViewModel(assignment.Position);
            this.Project = new ProjectViewModel(assignment.Project);
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
    }
}
