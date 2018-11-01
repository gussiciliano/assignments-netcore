using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class OfficeViewModel : BaseEntityViewModel
    {
        public Country Country { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
    }
}
