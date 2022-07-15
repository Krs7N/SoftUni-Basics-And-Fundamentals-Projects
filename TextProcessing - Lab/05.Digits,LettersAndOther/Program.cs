using System;
using System.Linq;
using System.Text;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();

            char[] digits = strings.Where(ch => char.IsDigit(ch)).ToArray();
            char[] letters = strings.Where(ch => char.IsLetter(ch)).ToArray();
            char[] others = strings.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
