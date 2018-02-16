using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog(),
                new Cat()
            };

            foreach (var animal in animals)
            {
                animal.Move();
                animal.Speak();
                animal.Tostring();
            }

            var dogA = new Dog();
            var dogB = new Dog();
            dogA.Equals(dogB);


            
           
                
            

            
            
                
            

        }
    }
}
