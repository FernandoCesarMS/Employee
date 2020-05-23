using System;
using System.Collections.Generic;
using System.Globalization;
using Employees.Entities;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int amountEmployee = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountEmployee; i++)
            {
                Console.WriteLine("Employee #{0} data:",i+1);
                Console.Write("Outsourced (y/n)? ");
                string choice = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (choice == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    OutsourcedEmployee aux = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    list.Add(aux);
                }
                else
                {
                    Employee aux = new Employee(name,hours,valuePerHour);
                    list.Add(aux);
                }
            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach (Employee employee in list)
            {
                Console.WriteLine("{0} - $ {1}",employee.Name,employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
