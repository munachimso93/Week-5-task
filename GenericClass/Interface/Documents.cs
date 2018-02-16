using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Interface
{
    class Documents : Iprintable,Istorable
    {
        public void ExportTo()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public void write()
        {
            throw new NotImplementedException();
        }
    }
}
