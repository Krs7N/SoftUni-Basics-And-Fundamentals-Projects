using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var piecesByComposerAndKey = new Dictionary<string, Dictionary<string, string>>();
            var ordered = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] pieces = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                piecesByComposerAndKey.Add(piece, new Dictionary<string, string>());
                piecesByComposerAndKey[piece].Add(composer, key);
                ordered.Add(piece);
            }

            string[] commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Stop")
            {
                string action = commands[0];
                string piece = string.Empty;
                string composer = string.Empty;
                string key = string.Empty;

                switch (action)
                {
                    case "Add":
                        piece = commands[1];
                        composer = commands[2];
                        key = commands[3];
                        Add(piecesByComposerAndKey, ordered, piece, composer, key);
                        break;
                    case "Remove":
                        piece = commands[1];
                        Remove(piecesByComposerAndKey, ordered, piece);
                        break;
                    case "ChangeKey":
                        piece = commands[1];
                        string newKey = commands[2];
                        string tempKey = string.Empty;

                        tempKey = ChangeKey(piecesByComposerAndKey, piece, newKey, tempKey);
                        break;
                }

                commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            }

            //foreach (var pieceByComposerAndKey in ordered)
            //{
            //    foreach (var composerAndKey in piecesByComposerAndKey[pieceByComposerAndKey])
            //    {
            //        Console.WriteLine($"{pieceByComposerAndKey} -> Composer: {composerAndKey.Key}, Key: {composerAndKey.Value}");
            //    }
            //}

            foreach (var pieceByComposerAndKey in piecesByComposerAndKey)
            {
                string composer = pieceByComposerAndKey.Value.FirstOrDefault().Key;
                string key = pieceByComposerAndKey.Value.FirstOrDefault().Value;
                Console.WriteLine($"{pieceByComposerAndKey.Key} -> Composer: {composer}, Key: {key}");
            }
        }

        static void Add(Dictionary<string, Dictionary<string, string>> piecesByComposerAndKey, List<string> ordered, string piece, string composer, string key)
        {
            if (!piecesByComposerAndKey.ContainsKey(piece))
            {
                piecesByComposerAndKey.Add(piece, new Dictionary<string, string>());
                piecesByComposerAndKey[piece].Add(composer, key);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                ordered.Add(piece);
            }
            else
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
        }

        static void Remove(Dictionary<string, Dictionary<string, string>> piecesByComposerAndKey, List<string> ordered, string piece)
        {
            if (piecesByComposerAndKey.ContainsKey(piece))
            {
                piecesByComposerAndKey.Remove(piece);
                ordered.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }


        static string ChangeKey(Dictionary<string, Dictionary<string, string>> piecesByComposerAndKey, string piece, string newKey, string tempKey)
        {
            if (piecesByComposerAndKey.ContainsKey(piece))
            {
                tempKey = piecesByComposerAndKey[piece].Keys.First();
                piecesByComposerAndKey[piece][tempKey] = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }

            return tempKey;
        }
    }
}