using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class JobRoleRepository : Repository<JobRole>, IJobRoleRepository
    {
        public JobRoleRepository(DataBaseContext context) : base(context) { }
    }
}
