using System;
using UnityEngine;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public class Vector3<T>
    {
        public Vector3(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        [field: SerializeField]
        public T X { get; private set; }

        [field: SerializeField]
        public T Y { get; private set; }

        [field: SerializeField]
        public T Z { get; private set; }
    }
}