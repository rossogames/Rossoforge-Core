using Rossoforge.Core.Services;
using UnityEngine;

namespace Rossoforge.Core.Pool
{
    public interface IPoolService : IService
    {
        T Get<T>(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo, string category) where T : Component;
        IPooledObject Get(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo, string category);
        void Populate(IPooledGameobjectData data, string category);
        void ForceReturnAll();

#if HAS_ADDRESSABLES
        Awaitable<T> GetAsync<T>(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo, string category) where T : Component;
        Awaitable<IPooledObject> GetAsync(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo, string category);
        Awaitable PopulateAsync(IPooledObjectAsyncData data, string category);
#endif

        bool Clear(IPooledObjectData data);
        bool Clear(string category);
    }
}
