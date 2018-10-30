using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class ProjectComponentRepository : Repository<ProjectComponent>, IProjectComponentRepository
    {
        public ProjectComponentRepository(DataBaseContext context) : base(context) { }
    }
}
