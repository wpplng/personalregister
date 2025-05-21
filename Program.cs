using System;

namespace personalregister
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        // skapa anställd med namn och lön   
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }

    public class EmployeeList
    {
        // skapa lista med anställda
        private List<Employee> Employees = new List<Employee>();

        public void AddEmployee(string name, int salary)
        {
            Employee newEmployee = new Employee(name, salary);
            // lägg till anställd i listan
            Employees.Add(newEmployee);
        }

        public void PrintAllEmployees()
        {
            // skriv ut alla anställda i listan
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new EmployeeList();
            bool isActive = true;

            Console.WriteLine("Personalregister");

            while (isActive)
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Lägg till anställd");
                Console.WriteLine("2. Visa en lista med alla anställda");
                Console.WriteLine("3. Avsluta");
                Console.Write("Ditt val: ");
                string task = Console.ReadLine();

                switch (task)
                {
                    case "1":
                        string name;
                        while (true)
                        {
                            Console.Write("Ange namn: ");
                            name = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                break;
                            }
                            Console.WriteLine("Namnet får inte vara tomt. Försök igen.");
                        }           
                        int salary;
                        while (true)
                        {
                            Console.Write("Ange lön: ");
                            string salaryInput = Console.ReadLine();
                            if (int.TryParse(salaryInput, out salary) && salary >= 0)
                            {
                                break;
                            }
                            Console.WriteLine("Var vänlig ange ett positivt tal med siffror.");
                        }
                        Console.WriteLine($"Anställd {name} med lön {salary} har lagts till.");
                        list.AddEmployee(name, salary);
                        break;

                    case "2":
                        list.PrintAllEmployees();
                        break;

                    case "3":
                        isActive = false;
                        Console.WriteLine("Alla anställda är tillagda.");
                        break;

                    default:
                        Console.WriteLine("Något gick fel, försök igen");
                        break;
                }
            }
        }
    }
}