using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputRectangle
{
    class Program
    {
        public int getInt()
        {
            bool loop = true;
            int input = 0;
            while (loop == true)
            {
                Console.Write("Please input an integer from 1 to 9: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 9) Console.WriteLine("Input not accepted. Please try again.");
                else loop = false;
            }
            return input;
        }
        public void drawRect(int input)
        {
            int row, column, blank;
            for (row = 1; row <= input; row++)
            {
                if (row == 1)
                {
                    for (column = 1; column <= input; column++)
                    {
                        Console.Write(input);                        
                    }
                    Console.WriteLine();
                }
                else if (row < input)
                {
                    Console.Write(input);
                    for (blank = 1; blank <= input - 2; blank++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(input);
                }
                else
                {
                    for (column = 1; column <= input; column++)
                    {
                        Console.Write(input);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int input = p.getInt();
            p.drawRect(input);
            Console.ReadKey();
        }
    }
}
