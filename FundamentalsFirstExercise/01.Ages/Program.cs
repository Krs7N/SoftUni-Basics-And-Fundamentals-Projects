using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from the user
            int age = int.Parse(Console.ReadLine());

            //switch (age)
            //{
            //    case <= 2:
            //        Console.WriteLine("baby");
            //        break;
            //    case > 2 and <= 13:
            //        Console.WriteLine("child");
            //        break;
            //    case > 13 and <= 19:
            //        Console.WriteLine("teenager");
            //        break;
            //    case > 19 and <= 65:
            //        Console.WriteLine("adult");
            //        break;
            //    default:
            //        Console.WriteLine("elder");
            //        break;
            //}

            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age > 2 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age > 13 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age > 19 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
