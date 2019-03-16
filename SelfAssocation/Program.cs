using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssocation
{
    class Program
    {
        public void Method()
        {
            Console.WriteLine("Hello World !");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Method();

            Console.ReadKey();
        }
    }
}
