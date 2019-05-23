using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Views
{
    public class PositionViewModel : BaseEntityViewModel
    {
        public string Name { get; set; }
        public ICollection<AssignmentViewModel> Assignments { get; set; }
    }
}
