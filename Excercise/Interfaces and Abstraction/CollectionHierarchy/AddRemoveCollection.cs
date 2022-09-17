using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        private readonly IList<T> list;

        public AddRemoveCollection()
        {
            list = new List<T>();
        }

        public int Add(T item)
        {
            this.list.Insert(0, item);

            return 0;
        }
        public T Remove()
        {
            T elementToRemove = this.list.LastOrDefault();

            if (elementToRemove != null)
            {
                this.list.Remove(elementToRemove);
            }

            return elementToRemove;
        }
    }
}
