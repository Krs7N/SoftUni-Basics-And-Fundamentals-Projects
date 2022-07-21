using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fileLocation = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> desiredLocation = new List<string>();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            for (int i = fileLocation.Count - 1; i > 0; i--)
            {
                if (fileLocation[i].Contains('.'))
                {
                    desiredLocation = fileLocation[i].Split('.').ToList();
                    break;
                }
            }

            fileName = desiredLocation[0];
            fileExtension = desiredLocation[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
