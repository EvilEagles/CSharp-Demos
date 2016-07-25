using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTest
{
    class Program
    {
        public static int getInt()
        {
            bool loop = true;
            int result = 0;
            while (loop ==  true)
            {
                Console.Write("Please input an integer: ");
                result = Convert.ToInt32(Console.ReadLine());
                if (result == 0)
                {
                    Console.WriteLine("The input number must not be zero.");
                }
                else
                    loop = false;
            }
            return result;
        }
        public void triangleTest(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                int acreage = Convert.ToInt32((Math.Sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b))) / 4);
                if ((a == b) && (a == c))
                {
                    Console.WriteLine("This is an equilateral triangle.");
                    Console.WriteLine("Acreage: {0}", acreage);
                }
                else if ((a == b) || (b == c) || (a == c))
                {
                    Console.WriteLine("This is an isosceles triangle.");
                    Console.WriteLine("Acreage: {0}", acreage);
                }
                else if (   ((a * a + b * b == Math.Sqrt(c)) && (a == b)) || 
                            ((Math.Sqrt(a) + Math.Sqrt(c) == b * b) && (a == c)) || 
                            ((c * c + b * b == a * a) && (c == b))  
                        )
                {
                    Console.WriteLine("This is an isosceles right triangle.");
                    Console.WriteLine("Acreage: {0}", acreage);
                }
                else if (   (Math.Sqrt(a) == b * b + c * c) ||
                            (b * b == a * a + c * c) ||
                            (c * c == a * a + b * b)
                        )
                {
                    Console.WriteLine("This is a right triangle.");
                    Console.WriteLine("Acreage: {0}", acreage);
                }
                else
                {
                    Console.WriteLine("This is a scalene triangle.");
                    Console.WriteLine("Acreage: {0}", acreage);
                }
            }
            else
                Console.WriteLine("This is not a triangle.");
        }   
        public bool yesno()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Do you want to continue? Y/N");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    break;
                }
                else if (input.Key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    loop = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong answer.");
                    continue;
                }
            }
            return loop;
        }
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                int a = getInt();
                int b = getInt();
                int c = getInt();
                Program p = new Program();
                p.triangleTest(a, b, c);
                loop = p.yesno();
            }
        }
    }
}
