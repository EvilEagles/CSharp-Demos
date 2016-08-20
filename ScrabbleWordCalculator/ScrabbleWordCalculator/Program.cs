using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <INSTRUCTIONS>
/// Input the '*' symbol before the letter whose score you want to double.
/// Input the '@' symbol at any point to double the score of the entire word.
/// </INSTRUCTIONS>

namespace ScrabbleWordCalculator
{
    class Program
    {
        // DEFINING LETTER BLOCKS
        #region
        static char[] one = { 'a', 'e', 'i', 'l', 'n', 'o', 'r', 's', 't', 'u',
                       'A', 'E', 'I', 'L', 'N', 'O', 'R', 'S', 'T', 'U' };
        static char[] two = { 'd', 'g', 'D', 'G' };
        static char[] three = { 'b', 'c', 'm', 'p', 'B', 'C', 'M', 'P' };
        static char[] four = { 'f', 'h', 'v', 'w', 'y', 'F', 'H', 'V', 'W', 'Y' };
        static char[] five = { 'k', 'K' };
        static char[] eight = { 'j', 'x', 'J', 'X' };
        static char[] ten = { 'q', 'z', 'Q', 'Z' };
        #endregion

        // CONTROLLER VARIABLES
        #region
        public static bool letterX2 = false;
        public static bool wordX2 = false;
        public static int returnedValue;
        public static int score;
        #endregion

        // FUNCTION: GET THE SCORE FOR THE CHAR PARAMETER
        public static int getScore(char letter)
        {
            if (one.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 2;
            }
            else if (one.Contains(letter))
                return 1;


            else if (two.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 4;
            }
            else if (two.Contains(letter))
                return 2;


            else if (three.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 6;
            }
            else if (three.Contains(letter))
                return 3;


            else if (four.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 8;
            }
            else if (four.Contains(letter))
                return 4;


            else if (five.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 10;
            }
            else if (five.Contains(letter))
                return 5;


            else if (eight.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 16;
            }
            else if (eight.Contains(letter))
                return 8;


            else if (ten.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                return 20;
            }
            else if (ten.Contains(letter))
                return 10;


            else
                return 0;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please input a valid English word: ");
                string input = Console.ReadLine();
                foreach (char letter in input)
                {
                    if (letter == '*')
                    {
                        letterX2 = true;
                        continue;
                    }
                    else if (letter == '@')
                    {
                        wordX2 = true;
                        continue;
                    }
                    else
                    {
                        returnedValue = getScore(letter);
                        score += returnedValue;
                    }
                }
                if (wordX2 == true)
                {
                    score += score;
                    wordX2 = false;
                }
                Console.WriteLine("The score is: " + score);
                Console.WriteLine();
                score = 0;
            }
        }
    }
}
