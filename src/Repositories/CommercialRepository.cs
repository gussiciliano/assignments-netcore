using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
    public class CommercialRepository : Repository<Commercial>, ICommercialRepository
    {
        public CommercialRepository(DataBaseContext context) : base(context) { }
    }
}
