using System.Reflection;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employees=new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details of employee {i + 1}");

                Console.Write("Enter employee ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter employee salary: ");
                float salary = float.Parse(Console.ReadLine());

                Console.Write("Enter employee gender (M/F): ");
                Gender gender = Console.ReadLine()=="M" ? Gender.Male : Gender.Female;

                Console.WriteLine("Enter employee hire date:");
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                HireDate hireDate = new HireDate { day = day, month = month, year = year };

                
                Employees[i] = new Employee(id, salary, hireDate, gender);
            }

            Console.WriteLine("\nEmployee Details:\n");

            for (int j = 0; j < Employees.Length; j++)
            {
                Console.WriteLine($"Employee {j + 1}:");
                Console.WriteLine($"  ID: {Employees[j].id}");
                Console.WriteLine($"  Salary: {Employees[j].salary}");
                Console.WriteLine($"  Gender: {Employees[j].gender}");
                Console.WriteLine($"  Hire Date: {Employees[j].hireDate.day}/{Employees[j].hireDate.month}/{Employees[j].hireDate.year}");
                Console.WriteLine();
            }
        }
    }
}
    

