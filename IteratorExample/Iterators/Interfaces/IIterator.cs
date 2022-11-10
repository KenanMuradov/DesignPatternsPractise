using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample.Iterators.Interfaces;

public interface IIterator
{
    Employee First();
    Employee Next();

    bool IsCompleted { get; }
}
