using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(names);

            foreach (Match validName in validNames)
            {
                Console.Write(validName + " ");
            }
        }
    }
}
