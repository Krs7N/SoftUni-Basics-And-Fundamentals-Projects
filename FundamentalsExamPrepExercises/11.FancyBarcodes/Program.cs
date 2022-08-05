using System;
using System.Text.RegularExpressions;

namespace _11.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForBarcode = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            string patternForBarcodeDigits = @"\d";

            int countOfBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                if (!Regex.IsMatch(barcode, patternForBarcode))
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    MatchCollection matches = Regex.Matches(barcode, patternForBarcodeDigits);
                    if (matches.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", matches)}");
                    }
                }
            }
        }
    }
}