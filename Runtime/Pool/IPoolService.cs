using Rossoforge.Core.Services;
using UnityEngine;

namespace Rossoforge.Core.Pool
{
    public interface IPoolService : IService
    {
        public const string DEFAULT_CATEGORY = "default";

        T Get<T>(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY) where T : Component;
        IPooledObject Get(IPooledGameobjectData data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY);
        void Populate(IPooledGameobjectData data, string category = DEFAULT_CATEGORY);
        void ForceReturnAll();

#if HAS_ADDRESSABLES
        Awaitable<T> GetAsync<T>(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY) where T : Component;
        Awaitable<IPooledObject> GetAsync(IPooledObjectAsyncData data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY);
        Awaitable PopulateAsync(IPooledObjectAsyncData data, string category = DEFAULT_CATEGORY);
#endif

        bool Clear(IPooledObjectData data);
        bool Clear(string category);
    }
}
