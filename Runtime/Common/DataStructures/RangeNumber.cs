using System;
using UnityEngine;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public class RangeNumber<T> where T : IComparable<T>
    {
        public RangeNumber()
        {
        }
        public RangeNumber(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        [field: SerializeField]
        public T Min { get; private set; }

        [field: SerializeField]
        public T Max { get; private set; }
    }
}