using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyByEmployee = new Dictionary<string, List<string>>();

            string[] info = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            while (info[0] != "End")
            {
                string companyName = info[0];
                string employeeId = info[1];

                if (!companyByEmployee.ContainsKey(companyName))
                {
                    companyByEmployee.Add(companyName, new List<string>());
                }
                else
                {
                    if (companyByEmployee[companyName].Contains(employeeId))
                    {
                        info = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                }

                companyByEmployee[companyName].Add(employeeId);

                info = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var employeeByCompany in companyByEmployee)
            {
                Console.WriteLine(employeeByCompany.Key);
                foreach (var employee in employeeByCompany.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
