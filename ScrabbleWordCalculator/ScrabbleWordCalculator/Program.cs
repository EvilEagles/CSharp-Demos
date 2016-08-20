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
        public static int letterScore;
        public static int wordScore;
        public static int totalScore;
        public static string name;        
        #endregion

        // FUNCTION: GET THE SCORE FOR THE CHAR PARAMETER
        public static int getScore(char letter)
        {
            if (one.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(1x2) ");
                return 2;
            }
            else if (one.Contains(letter))
            {
                Console.Write(letter + "(1) ");
                return 1;
            }
            else if (two.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(2x2) ");
                return 4;
            }
            else if (two.Contains(letter))
            {
                Console.Write(letter + "(2) ");
                return 2;
            }
            else if (three.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(3x2) ");
                return 6;
            }
            else if (three.Contains(letter))
            {
                Console.Write(letter + "(3) ");
                return 3;
            }                
            else if (four.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(4x2) ");
                return 8;
            }
            else if (four.Contains(letter))
            {
                Console.Write(letter + "(4) ");
                return 4;
            }
                
            else if (five.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(5x2) ");
                return 10;
            }
            else if (five.Contains(letter))
            {
                Console.Write(letter + "(5) ");
                return 5;
            }                
            else if (eight.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(8x2) ");
                return 16;
            }
            else if (eight.Contains(letter))
            {
                Console.Write(letter + "(8) ");
                return 8;
            }                
            else if (ten.Contains(letter) && letterX2 == true)
            {
                letterX2 = false;
                Console.Write(letter + "(10x2) ");
                return 20;
            }
            else if (ten.Contains(letter))
            {
                Console.Write(letter + "(10) ");
                return 10;
            }                
            else
                return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Please input player name: ");
            name = Console.ReadLine();
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
                        letterScore = getScore(letter);
                        wordScore += letterScore;
                    }
                }
                if (wordX2 == true)
                {
                    Console.WriteLine("   | Word x 2: YES");
                    wordScore += wordScore;
                    wordX2 = false;
                }
                else
                    Console.Write("   | Word x 2: NO");
                totalScore += wordScore;
                Console.WriteLine("Player name: {0}     | Word Score: {1}       | Total Score: {2}", name, wordScore, totalScore);           
                Console.WriteLine();                
                wordScore = 0;
            }
        }
    }
}
