using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class MyList<T> : IList<T>
    {
        private readonly IList<T> l = new List<T>();
        public T this[int c] { get => l[c]; set => l[c] = value; }
        public int Count => l.Count;
        public bool IsReadOnly => l.IsReadOnly;
        public void Add(T d)
        {
            l.Add(d);
        }
        public void Clear()
        {
            l.Clear();
        }
        public void CopyTo(T[] ar, int arrayIndex)
        {
            l.CopyTo(ar, arrayIndex);
        }
        public bool Contains(T d)
        {
            return l.Contains(d);
        }
        public void Insert(int c, T d)
        {
            l.Insert(c, d);
        }
        public int IndexOf(T d)
        {
            return l.IndexOf(d);
        }
        public bool Remove(T d)
        {
            return l.Remove(d);
        }
        public void RemoveAt(int c)
        {
            l.RemoveAt(c);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return l.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
