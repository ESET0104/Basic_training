using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal class Printer : Interface1
    {
        public void print() 
        {
            Console.WriteLine("its printing from printer");
        }
    }
}
