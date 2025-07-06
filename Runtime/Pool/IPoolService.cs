using Rossoforge.Core.Services;
using UnityEngine;

namespace Rossoforge.Core.Pool
{
    public interface IPoolService : IService
    {
        T Get<T>(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo) where T : Component;
        IPooledObject Get(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo);
        void Populate(IPooledGameobjectData data);

        Awaitable<T> GetAsync<T>(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo) where T : Component;
        Awaitable<IPooledObject> GetAsync(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo);
        Awaitable PopulateAsync(IPooledObjectAsyncData data);

        bool Clear(IPooledObjectData data);
    }
}
