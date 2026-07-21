using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rossoforge.Core.DataStructures
{
    [Serializable]
    public class WeightedList<T> : IEnumerable<WeightedItem<T>>
    {
        public List<WeightedItem<T>> Items = new();

        public T this[int index] => Items[index].Item;
        public int Count => Items?.Count ?? 0;

        public void Add(T item, float weight)
        {
            Items ??= new List<WeightedItem<T>>();
            Items.Add(new WeightedItem<T> { Item = item, Weight = Mathf.Max(0f, weight) });
        }

        public T GetRandomItem()
        {
            if (Items == null || Items.Count == 0)
                return default;

            float totalWeights = 0f;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Weight > 0f)
                    totalWeights += Items[i].Weight;
            }

            if (totalWeights <= 0f)
                return default;

            float random = UnityEngine.Random.Range(0f, totalWeights);

            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                if (item.Weight <= 0f) 
                    continue;

                if (random < item.Weight)
                    return item.Item;

                random -= item.Weight;
            }

            return Items[^1].Item;
        }

        public int IndexOf(T item)
        {
            if (Items == null) return -1;
            var comparer = EqualityComparer<T>.Default;

            for (int i = 0; i < Items.Count; i++)
            {
                if (comparer.Equals(Items[i].Item, item))
                    return i;
            }
            return -1;
        }

        public IEnumerator<WeightedItem<T>> GetEnumerator() => (Items ?? new List<WeightedItem<T>>()).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}