using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class CommercialViewModel : ProjectViewModel
    {
        public CommercialViewModel(Commercial commercial) : base(commercial)
        {
            this.IsTeamAugmentation = commercial.IsTeamAugmentation;
        }

        public bool IsTeamAugmentation { get; set; }
    }
}
