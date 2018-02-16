using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dogs move and run" );
        }

        public override void Speak()
        {
            Console.WriteLine("Dogs Barks out loud");
        }

        public override void Tostring()
        {
            Console.WriteLine("Dogs are animals");
        }
    }
}   

