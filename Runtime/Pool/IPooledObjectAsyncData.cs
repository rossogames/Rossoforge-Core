using UnityEngine.AddressableAssets;

namespace Rossoforge.Core.Pool
{
    public interface IPooledObjectAsyncData : IPooledObjectData
    {
        AssetReferenceGameObject AssetReference { get; }
    }
}