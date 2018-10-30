using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories;
using AssignmentsNetcore.Repositories.Database;
using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories
{
  public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
  {
    public AssignmentRepository(DataBaseContext context) : base(context) { }
  }
}
