using AssignmentsNetcore.Repositories.Interfaces;

namespace AssignmentsNetcore.Repositories.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;
        public UnitOfWork(DataBaseContext context)
        {
            this._context = context;
            this.AssignmentRepository = new AssignmentRepository(_context);
            this.ClientRepository = new ClientRepository(_context);
            this.OfficeRepository = new OfficeRepository(_context);
            this.PersonRepository = new PersonRepository(_context);
            this.TabRepository = new TabRepository(_context);
            this.ProjectRepository = new ProjectRepository(_context);
            this.TechRepository = new TechRepository(_context);
            this.TrainingRepository = new TrainingRepository(_context);
            this.PositionRepository = new PositionRepository(_context);
            this.CountryRepository = new CountryRepository(_context);
        }

        public IAssignmentRepository AssignmentRepository { get; private set; }
        public IClientRepository ClientRepository { get; private set; }
        public IOfficeRepository OfficeRepository { get; private set; }
        public IPersonRepository PersonRepository { get; private set; }
        public IPositionRepository PositionRepository { get; private set; }
        public ITabRepository TabRepository { get; private set; }
        public IProjectRepository ProjectRepository { get; private set; }
        public ITechRepository TechRepository { get; private set; }
        public ITrainingRepository TrainingRepository { get; private set; }
        public ICountryRepository CountryRepository { get; private set; }

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
