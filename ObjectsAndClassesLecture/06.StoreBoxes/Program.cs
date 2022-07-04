using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "end")
            {
                string serialNumber = commands[0];
                string itemName = commands[1];
                int itemQuantity = int.Parse(commands[2]);
                decimal itemPrice = decimal.Parse(commands[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item(itemName, itemPrice),
                    Quantity = itemQuantity
                };

                boxes.Add(box);

                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.PriceBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox => Quantity * Item.Price;
    }
}
