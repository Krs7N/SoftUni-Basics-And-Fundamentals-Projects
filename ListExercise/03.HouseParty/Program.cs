using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = new List<string>();
            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] names = Console.ReadLine().Split();
                if (listOfNames.Contains(names[0]) && names[2] == "going!")
                {
                    Console.WriteLine($"{names[0]} is already in the list!");
                }
                else if (listOfNames.Contains(names[0]) && names[2] == "not")
                {
                    listOfNames.Remove(names[0]);
                }
                else if (!listOfNames.Contains(names[0]) && names[2] == "not")
                {
                    Console.WriteLine($"{names[0]} is not in the list!");
                }
                else if (!listOfNames.Contains(names[0]) && names[2] == "going!")
                {
                    listOfNames.Add(names[0]);
                }
            }

            foreach (string name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
