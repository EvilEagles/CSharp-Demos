using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date: {0}/{1}/{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            Console.WriteLine("Please input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if(b > a)
            {
                Console.WriteLine("{0} > {1}", b, a);
            }
            else
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
            Console.ReadKey();
        }

        // Data type

    }
}
