using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class TabRepository : Repository<Tab>, ITabRepository
    {
        public TabRepository(DataBaseContext context) : base(context) { }
    }
}
