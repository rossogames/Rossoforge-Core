using UnityEngine;

namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledGameobjectData : IPooledObjectData
    {
        GameObject AssetReference { get; }
    }
}