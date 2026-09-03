using System;
using UnityEngine;

namespace Rossoforge.Pool.Service
{
    public interface IPooledObject
    {
        event Action<IPooledObject> OnReturnedToPool;

        GameObject gameObject { get; }
        Transform transform { get; }

        void ReturnToPool();
    }
}