using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word to check if it's a Palindrome"); // Ask the user to enter a string
            Stack<char> cstack = new Stack<char>(); //Add to stack
            string input = Console.ReadLine(); // Store the string


            var inputToUpper = input.ToUpper(); /*Change to upper case */

            foreach (char c in inputToUpper)
            {
                cstack.Push(c);
            }

            bool Palindrome = true;
            var Items = cstack.Count;

            for (int i = 0; i < Items; i++)
            {
                if (inputToUpper[i] != cstack.Pop())
                {
                    Palindrome = false; break;
                }
            }

            if (Palindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not an Palindrome");


            }
             Console.ReadLine();
        }
    }
}

      