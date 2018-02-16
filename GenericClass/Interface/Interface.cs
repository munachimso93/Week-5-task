using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass.Interface
{
     interface Iprintable
    {
 
       void print();
        void ExportTo();
    }

    interface Istorable
    {
        void read();
        void write();
    }
}  
