using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRec
{
    class Program
    {
        public static void print(char key, int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write(key);
            }
        }

        public void drawRect(int a, int b)
        {
            print('*', a);
            Console.Write("\n");
            for (int i = 1; i <= a; i++)
            {
                print('*', 1);
                print(' ', a - 2);
                print('*', 1);
                Console.Write("\n");
            }
            print('*', a);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Please input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            p.drawRect(a, b);
            Console.ReadKey();
        }
    }
}
