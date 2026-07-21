using System;

namespace Rossoforge.Core.DataStructures
{
    [Serializable]
    public struct WeightedItem<T>
    {
        public T Item;
        public float Weight;
    }
}