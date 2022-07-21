using System;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(input[i]);
                }
                else if (power == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
