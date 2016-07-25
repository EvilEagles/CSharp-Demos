using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i, j;
            Console.WriteLine("Please input n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n - 1; i++)            // Line check
            {
                for (j = 1; j <= n - i; j++)        // Space before first star
                {     
                    Console.Write(" ");
                }
                    if (i > 1) Console.Write("* "); // Make sure there is no second star on the first line
                for (j = 3; j <= i; j++)            // Space within the triangle 
                {
                    Console.Write("  ");
                }
                Console.Write("*");                 // The last (enclosing) star on every line
                Console.WriteLine();                // Go to the next line
            }
            for (j = 1; j <= i; j++)                // Drawing the last line
            {
                Console.Write("* ");
            }
            Console.ReadKey();

        }
    }
}  

