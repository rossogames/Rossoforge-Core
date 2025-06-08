using UnityEngine.AddressableAssets;

namespace RossoForge.Core.Pool
{
    public interface IPooledObjectAsyncData : IPooledObjectData
    {
        AssetReferenceGameObject AssetReference { get; }
    }
}