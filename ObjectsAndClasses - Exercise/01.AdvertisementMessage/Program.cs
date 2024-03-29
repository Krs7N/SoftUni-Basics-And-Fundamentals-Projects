﻿using System;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int numberOfCreatedMessages = int.Parse(Console.ReadLine());

            Random randomMessage = new Random();

            for (int i = 0; i < numberOfCreatedMessages; i++)
            {
                string phrase = phrases[randomMessage.Next(0, phrases.Length)];
                string curEvent = events[randomMessage.Next(0, events.Length)];
                string author = authors[randomMessage.Next(0, authors.Length)];
                string city = cities[randomMessage.Next(0, cities.Length)];

                Console.WriteLine($"{phrases} {events} {authors} – {cities}.");
            }
        }
    }
}
