using AssignmentsNetcore.Models.Database;
using Microsoft.EntityFrameworkCore;
using AssignmentsNetcore.Repositories;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public class TechsRepository : Repository<Tech>, ITechsRepository
    {
        public TechsRepository(DbContext context) : base(context) { }
    }
}
