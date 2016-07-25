using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2
{
    class Program
    {
        public double getscore()
        {
            Console.WriteLine("Please input score:");
            double score = Convert.ToDouble(Console.ReadLine());
            return score;
        }

        public void rate(double score)
        {
            if (score >= 9)
            {
                Console.WriteLine("Hoc sinh Xuat Sac");
            }
            else if (score >= 8 && score < 9)
            {
                Console.WriteLine("Hoc sinh Gioi");
            }
            else if (score >= 7 && score < 8)
            {
                Console.WriteLine("Hoc sinh Kha");
            }
            else if (score >= 6 && score < 7)
            {
                Console.WriteLine("Hoc sinh Trung Binh Kha");
            }
            else if (score >= 5 && score < 6)
            {
                Console.WriteLine("Hoc sinh Trung Binh");
            }
            else
            {
                Console.WriteLine("Hoc sinh Yeu");
            }
        }
        static void Main(string[] args)
        {
                Program p = new Program();
                double score = p.getscore();
                p.rate(score);
                Console.ReadKey();
        }
    }
}
