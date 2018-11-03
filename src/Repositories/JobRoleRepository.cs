using System.Collections.Generic;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsNetcore.Repositories
{
    public class JobRoleRepository : Repository<JobRole>, IJobRoleRepository
    {
        public JobRoleRepository(DataBaseContext context) : base(context) { }

        public IEnumerable<JobRole> GetAllWithTechs() => Context.JobRole.Include(j => j.Tech).ToList();
    }
}
