using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Dog_2
{
    public class Dog2
    {
        public string Name;

        public override bool Equals(object obj)
        {
            // cast the object type to be a Dog2 type
            var dog = (Dog2)obj;
            // compare the names of the dogs and store the bool value
            var isSame = this.Name == dog.Name;
            return isSame;
        }
    }
}
