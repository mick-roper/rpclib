using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RpcLib.Abstractions
{
    public sealed class Appendable<T> : IEnumerable<T>
    {
        readonly List<T> items;

        public Appendable() : this(null)
        {

        }

        public Appendable(IEnumerable<T> initialItems)
        {
            items = initialItems != null ? new List<T>(initialItems) : new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (items as IEnumerable).GetEnumerator();
        }
    }
}
