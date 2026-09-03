using UnityEngine;

namespace Rossoforge.Pool.DataConfig
{
    public interface IPooledGameobjectDataConfig : IPooledObjectDataConfig
    {
        GameObject AssetReference { get; }
    }
}