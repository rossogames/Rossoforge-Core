#if HAS_ADDRESSABLES
using UnityEngine.AddressableAssets;

namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledObjectAsyncDataConfig : IPooledObjectDataConfig
    {
        AssetReferenceGameObject AssetReference { get; }
    }
}
#endif