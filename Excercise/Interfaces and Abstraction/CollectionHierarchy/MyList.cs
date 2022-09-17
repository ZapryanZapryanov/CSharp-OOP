using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList<T> : IMyList<T>
    {
        private readonly IList<T> list;
        public int Used => list.Count;
        public MyList()
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
            T elementToRemove = this.list.FirstOrDefault();

            if (elementToRemove != null)
            {
                this.list.Remove(elementToRemove);
            }

            return elementToRemove;
        }

    }
}
