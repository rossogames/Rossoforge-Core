using System;
using UnityEngine;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public class BoxBounds<T>
    {
        [field: SerializeField]
        public T Left { get; private set; }

        [field: SerializeField]
        public T Right { get; private set; }

        [field: SerializeField]
        public T Top { get; private set; }

        [field: SerializeField]
        public T Bottom { get; private set; }
    }
}