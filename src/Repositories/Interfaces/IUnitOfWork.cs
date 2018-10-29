using System;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
