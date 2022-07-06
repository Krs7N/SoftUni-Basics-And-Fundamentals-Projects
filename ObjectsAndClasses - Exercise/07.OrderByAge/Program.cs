using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInformation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            while (userInformation[0] != "End")
            {
                string name = userInformation[0];
                string id = userInformation[1];
                int age = int.Parse(userInformation[2]);

                Person person = new Person(name, id, age);
                people.Add(person);

                userInformation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            people.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
