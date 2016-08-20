using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            double d = 34.340;
            fun(i);
            fun(d);

            Console.ReadKey();
        }

        static void fun(double d)
        {
            Console.WriteLine(d + " ");
        }
    }
}
