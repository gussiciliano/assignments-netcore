using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class TechRepository : Repository<Tech>, ITechRepository
    {
        public TechRepository(DataBaseContext context) : base(context) { }
    }
}
