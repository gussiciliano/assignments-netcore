using System;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAssignmentRepository AssignmentRepository { get; }
        IClientRepository ClientRepository { get; }
        ICommercialRepository CommercialRepository { get; }
        IOfficeRepository OfficeRepository { get; }
        IPersonRepository PersonRepository { get; }
        IPositionRepository PositionRepository { get; }
        ICountryRepository CountryRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IProjectComponentRepository ProjectComponentRepository { get; }
        ITechRepository TechRepository { get; }
        ITrainingRepository TrainingRepository { get; }

        int Complete();
    }
}
