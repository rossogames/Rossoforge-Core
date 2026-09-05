using System;
using UnityEngine;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public class Size2<T> where T : struct, IComparable<T>
    {
        public Size2(T width, T height)
        {
            this.Width = width;
            this.Height = height;
        }

        [field: SerializeField]
        public T Width { get; private set; }

        [field: SerializeField]
        public T Height { get; private set; }
    }
}