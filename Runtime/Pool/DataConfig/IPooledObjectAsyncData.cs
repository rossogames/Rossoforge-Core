#if HAS_ADDRESSABLES
using UnityEngine.AddressableAssets;

namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledObjectAsyncData : IPooledObjectData
    {
        AssetReferenceGameObject AssetReference { get; }
    }
}
#endif