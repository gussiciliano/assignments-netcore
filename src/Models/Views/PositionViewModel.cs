using System.Collections.Generic;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class PositionViewModel : BaseEntityViewModel
    {
        public PositionViewModel() { }

        public PositionViewModel(Position position) : base(position)
        {
            this.Name = position.Name;
        }

        public string Name { get; set; }
    }
}
