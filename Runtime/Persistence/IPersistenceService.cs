using Rossoforge.Services.Service;

namespace Rossoforge.Persistence.Service
{
    public interface IPersistenceService<T> : IService where T : IPersistentData, new()
    {
        T Data { get; }
    }
}
