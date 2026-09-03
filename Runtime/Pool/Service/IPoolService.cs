using Rossoforge.Core.Services;
using Rossoforge.Pool.DataConfig;
using UnityEngine;

namespace Rossoforge.Pool.Service
{
    public interface IPoolService : IService
    {
        public const string DEFAULT_CATEGORY = "default";

        T Get<T>(IPooledGameobjectDataConfig data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY) where T : Component;
        IPooledObject Get(IPooledGameobjectDataConfig data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY);
        void Populate(IPooledGameobjectDataConfig data, string category = DEFAULT_CATEGORY);
        void ForceReturnAll();

#if HAS_ADDRESSABLES
        Awaitable<T> GetAsync<T>(IPooledObjectAsyncDataConfig data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY) where T : Component;
        Awaitable<IPooledObject> GetAsync(IPooledObjectAsyncDataConfig data, Transform parent, Vector3 position, Space relativeTo, string category = DEFAULT_CATEGORY);
        Awaitable PopulateAsync(IPooledObjectAsyncDataConfig data, string category = DEFAULT_CATEGORY);
#endif

        bool Clear(IPooledObjectDataConfig data);
        bool Clear(string category);
    }
}
