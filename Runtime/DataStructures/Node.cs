using System.Collections.Generic;

namespace Rossoforge.Core.DataStructures
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }

        public Node()
        {
            Children = new List<Node<T>>();
        }

        public Node(T value) : this()
        {
            Value = value;
        }

        public void AddChild(Node<T> child)
        {
            Children.Add(child);
        }

        public void AddChild(T value)
        {
            Children.Add(new Node<T>(value));
        }
    }
}