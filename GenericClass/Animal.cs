using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
     public abstract class Animal
    {
        private int weight;
        private string name;
        public abstract void Speak();

        public abstract void Move();

        public abstract void Tostring();



    }
}
