using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    class Program
    {
        // Methods to be used
        #region
        public static int getInt ()
        {
            Console.Write("Please input an integer: ");
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        public void highestOfThree(int a, int b, int c)
        {
            int highest = a;
            if (b > highest) highest = b;
            if (c > highest) highest = c;
            Console.WriteLine("The 3 input numbers are: {0}     {1}     {2}", a, b, c);
            Console.WriteLine("The highest number is: {0}", highest);
        }
        public int yesno()
        {
            int result = 0;
            while (result == 0)
            {
                Console.WriteLine("Do you want to continue? Y/N");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    result = 0;
                    break;
                }
                else if (input.Key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    result = 1;
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong answer.");
                    continue;
                }
            }
            return result;
        }
        #endregion 

        // Main Program
        static void Main(string[] args)
        {
            int answer = 0;     // Condition variable
            while (answer == 0) // Loop so that users may rerun the program as many times as they want
            {
                int a = getInt();
                int b = getInt();
                int c = getInt();
                Program p = new Program();
                p.highestOfThree(a, b, c);
                answer = p.yesno();
            }
            Console.ReadKey();  // Preventing the console from terminating immediately
        }
    }
}
