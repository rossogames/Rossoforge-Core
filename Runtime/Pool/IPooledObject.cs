using System;
using UnityEngine;

namespace RossoForge.Core.Pool
{
    public interface IPooledObject
    {
        event Action<IPooledObject> OnReturnedToPool;

        GameObject gameObject { get; }
        Transform transform { get; }

        void ReturnToPool();
    }
}