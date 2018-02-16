using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Cat : Animal
    {
        public override void Move()
        {
           Console.WriteLine("Cat Moves with legs");
        }

        public override void Speak()
        {
           Console.WriteLine("Cat makes a meww sounds");
        }

        public override void Tostring()
        {
            Console.WriteLine("Cat is an Animal");
        }
    }
}
