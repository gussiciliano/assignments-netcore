using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class OfficeRepository : Repository<Office>, IOfficeRepository
    {
        public OfficeRepository(DataBaseContext context) : base(context) { }
    }
}
