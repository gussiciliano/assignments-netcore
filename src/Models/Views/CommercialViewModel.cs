using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class CommercialViewModel : ProjectViewModel
    {
        public bool IsTeamAugmentation { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
    }
}
