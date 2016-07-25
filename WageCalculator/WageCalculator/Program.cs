using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalculator
{
    class Program
    {
        public static int getInt()
        {
            bool loop = true;
            int result = 0;
            while (loop == true)
            {
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
        public int wageCalculate(int hour, int rate)
        {
            int paycheck;
            if (hour <= 40)     paycheck = hour * rate;
            else                paycheck = (rate * 40) + ((hour - 40) * (rate * 2));
            return paycheck;
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
                    Console.WriteLine("=====================================");
                    break;
                }
                else if (input.Key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    Console.WriteLine("=====================================");
                    loop = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong answer.");
                    Console.WriteLine("=====================================");
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
                Console.Write("Please input work hours: ");
                int hour = getInt();
                Console.Write("Please input hourly rate: ");
                int rate = getInt();
                Program p = new Program();
                int paycheck = p.wageCalculate(hour, rate);
                Console.WriteLine("Paycheck: ${0}", paycheck);
                loop = p.yesno();
            }
        }
    }
}
