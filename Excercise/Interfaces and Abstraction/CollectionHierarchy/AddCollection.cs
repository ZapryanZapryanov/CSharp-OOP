using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection<T> : IAddCollection<T>
    {
        private readonly ICollection<T> list;
        public AddCollection()
        {
            list = new List<T>();
        }
        public int Add(T item)
        {
            list.Add(item);
            return this.list.Count - 1;
        }
    }
}
