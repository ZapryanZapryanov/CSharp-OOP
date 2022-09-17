using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
