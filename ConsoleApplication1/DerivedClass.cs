using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DerivedClass : BaseClass
    {
        public new void print()
        {
            Console.Out.WriteLine("this is derived Class: print mehtod");
        }

        public DerivedClass getType()
        {
            return new DerivedClass();
        }

        public override void printVirtual()
        {
            Console.Out.WriteLine("this is derived Class: printVirtual mehtod");
        }
    }
}
