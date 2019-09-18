using System;
using System.Collections.Generic;
using AssignmentsNetcore.Models;
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
            this.PersonTechId = assignment.PersonTechId;
            this.PositionId = assignment.PositionId;
            this.ProjectId = assignment.ProjectId;
            this.PersonTech = assignment.PersonTech != null ? new PersonTechViewModel(assignment.PersonTech) : null;
            this.Position = assignment.Position != null ? new PositionViewModel(assignment.Position) : null;
            this.Project = assignment.Project != null ? new ProjectViewModel(assignment.Project) : null;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Workload { get; set; }
        public PersonTechViewModel PersonTech { get; set; }
        public PositionViewModel Position { get; set; }
        public int PersonTechId { get; set; }
        public int PositionId { get; set; }
        public int ProjectId { get; set; }
        public ProjectViewModel Project { get; set; }
        public ICollection<SelectListItem> PersonTechs { get; set; }
        public ICollection<SelectListItem> Tabs { get; set; }
        public ICollection<SelectListItem> Positions { get; set; }
        
    }
}
