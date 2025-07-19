using UnityEngine;

namespace Rossoforge.Core.Pool
{
    public interface IPooledGameobjectData : IPooledObjectData
    {
        GameObject AssetReference { get; }
    }
}