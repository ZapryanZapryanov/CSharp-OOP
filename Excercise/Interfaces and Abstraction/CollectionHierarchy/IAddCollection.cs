using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    interface IAddCollection<T>
    {
        int Add(T item);
    }
}
