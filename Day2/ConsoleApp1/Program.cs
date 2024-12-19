#pragma warning disable

using System;
using Day2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employees = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details of employee {i + 1}");
                Employees[i] = new Employee();

                Console.Write("Employee ID: ");
                Employees[i].ID = int.Parse(Console.ReadLine());

                Console.Write("Employee name: ");
                Employees[i].Name = (Console.ReadLine());

                try
                {
                    Console.Write("Employee age (18-45): ");
                    Employees[i].Age = int.Parse(Console.ReadLine());

                    if (Employees[i].Age < 18 || Employees[i].Age > 45)
                    {
                        throw new ArgumentOutOfRangeException("Age must be between 18 and 45.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for age.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please choose an age within the range (18-45).");
                }


                while (true)
                {
                    Console.Write("Employee target (+300): ");
                    float target = float.Parse(Console.ReadLine());

                    if (target >= 300)
                    {
                        Employees[i].Target = target; 
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid target. Target must be greater than or equal to 300.");
                    }
                }

                Console.Write("Employee level (Admin/Hr/Officer): ");
                string levelInput = Console.ReadLine();
                Employees[i].SecurityLevel = levelInput == "Admin"
                    ? SecurityLevel.Admin
                    : levelInput == "Hr"
                        ? SecurityLevel.Hr
                        : SecurityLevel.Officer;

                Console.Write("Employee salary (6000-20000): ");
                Employees[i].Salary = float.Parse(Console.ReadLine());
                if (Employees[i].Salary < 6000 || Employees[i].Salary > 20000)
                {
                    Console.WriteLine("Invalid salary. Please enter a salary within the range.");
                }

                Console.Write("Employee gender (M/F): ");
                string genderInput = Console.ReadLine();
                Employees[i].Gender = genderInput == "M" ? Gender.Male : Gender.Female;

                Console.WriteLine("Enter employee hire date:");
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Employees[i].HireDate = new HireDate(year, month, day);
            }

            Array.Sort(Employees, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

            Console.WriteLine("\nEmployees sorted by HireDate:");
            foreach (var emp in Employees)
            {
                Console.WriteLine($"ID: {emp.ID},Name: {emp.Name}, Age: {emp.Age}, Target: {emp.Target}, Level: {emp.SecurityLevel}, " +
                                  $"Salary: {emp.Salary}, Gender: {emp.Gender}, Hire Date: {emp.HireDate}");
            }
        }
    }
}
