using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAndy
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 69;
            for (int i = 0; i < 21; i = i + 4)
            {
                if (i % 2 == 0)
                    x = y - x;
                else
                    x = y + 1;
                y = y - 5;
            }
            Console.WriteLine("{0}, {1}", x, y);
            Console.ReadKey();
        }
     }
}

