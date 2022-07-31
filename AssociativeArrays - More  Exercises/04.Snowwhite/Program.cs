using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dwarfHatColorByNameAndPhysics = new Dictionary<string, List<Dwarf>>();
            var results = new List<Dwarf>();

            string[] dwarfInfo = Console.ReadLine().Split("<:>", StringSplitOptions.RemoveEmptyEntries);

            while (dwarfInfo[0] != "Once upon a time")
            {
                string dwarfName = dwarfInfo[0];
                string dwarfHatColor = dwarfInfo[1];
                int dwarfPhysics = int.Parse(dwarfInfo[2]);

                Dwarf dwarf = new Dwarf
                {
                    Name = dwarfName,
                    Color = dwarfHatColor,
                    Physics = dwarfPhysics
                };

                if (!dwarfHatColorByNameAndPhysics.ContainsKey(dwarfHatColor))
                {
                    dwarfHatColorByNameAndPhysics.Add(dwarfHatColor, new List<Dwarf>());
                    results.Add(dwarf);
                }
                else
                {
                    if (dwarfHatColorByNameAndPhysics[dwarfHatColor].Any(x => x.Name == dwarfName))
                    {
                        var betterDwarf = dwarfHatColorByNameAndPhysics[dwarfHatColor]
                            .FirstOrDefault(x => x.Name == dwarfName);
                        betterDwarf.Physics = Math.Max(dwarfPhysics, betterDwarf.Physics);
                    }
                    else
                    {
                        results.Add(dwarf);
                    }
                }

                dwarfHatColorByNameAndPhysics[dwarfHatColor].Add(dwarf);

                dwarfInfo = Console.ReadLine().Split("<:>", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var dwarf in results.OrderByDescending(x => x.Physics).ThenByDescending(d => dwarfHatColorByNameAndPhysics[d.Color].Count))
            {
                Console.WriteLine($"({dwarf.Color.Trim()}) {dwarf.Name.Trim()} <-> {dwarf.Physics}");
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Physics { get; set; }
    }
}
