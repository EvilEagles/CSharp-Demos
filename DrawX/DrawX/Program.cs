using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawX
{
    class Program
    {
        public static int getOddInt()
        {
            int input = 0;
            bool loop = true;
            while (loop == true)
            {
                Console.Write("Please input an odd number other than 1: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0) Console.WriteLine("Input is not an odd number. Please try again.");
                else if (input == 1) Console.WriteLine("Input is number 1. Please try again.");
                else loop = false;
            }
            return input;
        }
        public static void drawX(int height)
        {
            int row, column;
            // BEGIN drawing top half
            for (row = (height + 1) / 2; row >= 1; row--)            // Line check
            {
                for (column = (height + 1) / 2 - row; column >= 1; column--)        // Space before first star
                {
                    Console.Write(" ");
                }
                if (row > 1) Console.Write("* "); // Make sure there is no second star on the first line
                for (column = 3; column <= row; column++)            // Space within the triangle
                {
                    Console.Write("  ");
                }
                Console.Write("*");                 // The last (enclosing) star on every line
                Console.WriteLine();                // Go to the next line
            }
            // BEGIN drawing bottom half
            for (row = 2; row <= (height + 1) / 2; row++)       // Row = 2 because first line already done above
            {
                for (column = 1; column <= (height + 1) / 2 - row; column++)        // Space before first star
                {
                    Console.Write(" ");
                }
                if (row > 1) Console.Write("* ");     // Make sure there is no second star on the first line
                for (column = 3; column <= row; column++)            // Space within the triangle
                {
                    Console.Write("  ");
                }
                Console.Write("*");                 // The last (enclosing) star on every line
                Console.WriteLine();                // Go to the next line
            }
        }
        static void Main(string[] args)
        {
            int input = getOddInt();
            drawX(input);
            Console.ReadKey();
        }
    }
}
