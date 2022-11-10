using IteratorExample.Iterators.Concretes;
using System.Collections.Generic;
using IteratorExample.Collections.Interfaces;

namespace IteratorExample.Collections.Concretes;

public class ConcreteCollection : IMyCollection
{
    private List<Employee> listEmployees = new();
    //Create Iterator
    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }
    // Gets item count
    public int Count
    {
        get { return listEmployees.Count; }
    }
    //Add items to the collection
    public void AddEmployee(Employee employee)
    {
        listEmployees.Add(employee);
    }
    //Get item from collection
    public Employee GetEmployee(int IndexPosition)
    {
        return listEmployees[IndexPosition];
    }
}
