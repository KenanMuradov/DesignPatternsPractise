using IteratorExample.Iterators.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample.Collections.Interfaces
{
    internal interface IMyCollection
    {
        Iterator CreateIterator();
    }
}
