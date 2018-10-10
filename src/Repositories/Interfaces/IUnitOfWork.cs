using System;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITechsRepository TechsRepository { get; }
        int Complete();
    }
}
