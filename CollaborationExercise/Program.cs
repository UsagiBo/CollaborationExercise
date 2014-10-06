using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CollaborationExercise
{
    class Program
    {
        private static void Main(string[] args)
        {
            string initial = "";

            Console.WriteLine("Enter text to check");

            string text = Console.ReadLine();

            int iLength = text.Length;

            if (iLength == 0)
            {
                Console.WriteLine("You did not enter any text");

            }

            else
            {

                for (int j = iLength - 1; j >= 0; j--)
                {
                    initial = initial + text[j];
                }

                if (initial == text)
                {
                    Console.WriteLine(text + " is palindrome");
                }
                else
                {
                    Console.WriteLine(text + " is not a palindrome");
                }


                Console.Read();
            }
        }

        /// <summary>
        /// return true if input is a palindrome
        /// else false
        /// </summary>
        /// <param name="text">text input to be validated</param>
        /// <returns></returns>
        /*private static bool IsPalindrome (string text)
        {
            
        }

        /*private static bool ContainsOnlyDigits(string text)
        {
            bool line;
            double retNum;

            line = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return line;
        }
        /*

        private static string ConvertToBinaryNumbers(int input)
        {
            
        }

        private static string ConvertToRomanNumbers(int input)
        {
            
        }*/
     }
}
