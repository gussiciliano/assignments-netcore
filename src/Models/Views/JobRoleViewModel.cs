using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class JobRoleViewModel : BaseEntityViewModel
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public JobRoleType JobRoleType { get; set; }
        // public virtual Tech Tech { get; set; }
    }
}
