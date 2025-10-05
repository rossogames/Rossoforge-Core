using System;
using UnityEngine;

namespace Rossoforge.Core.DataStructures
{
    [Serializable]
    public class Vector2<T>
    {
        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }

        [field: SerializeField]
        public T X { get; private set; }

        [field: SerializeField]
        public T Y { get; private set; }
    }
}