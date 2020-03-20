using System;

namespace ApplicationGeneric.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}