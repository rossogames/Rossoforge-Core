using System;
using UnityEngine;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public class Size3<T> where T : struct, IComparable<T>
    {
        public Size3(T width, T height, T depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        [field: SerializeField]
        public T Width { get; private set; }

        [field: SerializeField]
        public T Height { get; private set; }

        [field: SerializeField]
        public T Depth { get; private set; }
    }
}