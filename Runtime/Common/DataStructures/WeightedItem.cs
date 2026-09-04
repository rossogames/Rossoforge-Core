using System;

namespace Rossoforge.Common.DataStructures
{
    [Serializable]
    public struct WeightedItem<T>
    {
        public T Item;
        public float Weight;
    }
}