using System;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAssignmentRepository AssignmentRepository { get; }
        IClientRepository ClientRepository { get; }
        IOfficeRepository OfficeRepository { get; }
        IPersonRepository PersonRepository { get; }
        IPositionRepository PositionRepository { get; }
        ICountryRepository CountryRepository { get; }
        ITabRepository TabRepository { get; }
        IProjectRepository ProjectRepository { get; }
        ITechRepository TechRepository { get; }
        ITrainingRepository TrainingRepository { get; }

        int Complete();
    }
}
