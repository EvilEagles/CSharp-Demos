using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoop
{
    class Program
    {
        public int getInt()
        {
            Console.Write("Please input an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public void print(int input)
        {
            for(int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", input);
                Console.WriteLine("{0}{0}{0}{0}", input);    
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int input = p.getInt();
            p.print(input);
            Console.ReadKey();
        }
    }
}
