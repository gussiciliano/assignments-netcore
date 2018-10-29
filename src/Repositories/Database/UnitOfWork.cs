using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;
        public UnitOfWork(DataBaseContext context)
        {
            this._context = context;
            TechsRepository = new TechsRepository(_context);
        }
        public ITechsRepository TechsRepository { get; private set; }
        public int Complete()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
