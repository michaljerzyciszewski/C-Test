using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BaseClass
    {
        public void print()
        {
            Console.Out.WriteLine("this is base Class: print mehtod");
        }

        public BaseClass getType()
        {
            return new BaseClass();
        }

        public virtual void printVirtual()
        {
            Console.Out.WriteLine("this is base Class: printVirtual mehtod");
        }
    }
}
