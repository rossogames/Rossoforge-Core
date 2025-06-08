using UnityEngine;

namespace RossoForge.Core.Pool
{
    public interface IPooledGameobjectData : IPooledObjectData
    {
        GameObject AssetReference { get; }
    }
}