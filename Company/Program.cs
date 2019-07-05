using System;
using System.Collections.Generic;
using System.Globalization;
using Company.Entities;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nOfEmployees = int.Parse(Console.ReadLine());

            for(int i=1; i<=nOfEmployees; i++)
            {
                Employee employee;
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (isOutsourced == 'y' || isOutsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                } else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }
                employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
