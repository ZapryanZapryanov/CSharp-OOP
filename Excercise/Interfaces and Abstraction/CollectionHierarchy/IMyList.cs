using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    interface IMyList<T> : IAddRemoveCollection<T>
    {
        public int Used { get; }
    }
}
