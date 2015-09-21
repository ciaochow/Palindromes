using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Let's check for Palindromes -----");
            Console.Write("\nPlease enter a string: ");
            string input = Console.ReadLine();
            var reverse = new string(input.ToCharArray().Reverse().ToArray());
            var palindrome = input;
            if (palindrome == reverse)
            {
                Console.WriteLine("\n{0} is a palindrome of {1}.",reverse,input);
            }
            else Console.WriteLine("\n{0} is not a palindrome.", input);
            Console.Write("Press any key to quit... ");
            Console.ReadKey();
        }
    }
}
