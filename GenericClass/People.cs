using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class People<T>
    {
        public People(T t)
        {

        }
        public  void AddPerson(T item)
        {
            Peoples.Push(item);
        }
        public T CurrentPerson { get; set; }
        public Stack<T> Peoples { get; set; } = new Stack<T>();
    }
}
