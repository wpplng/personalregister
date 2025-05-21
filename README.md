# Personalregister

Skapa ett personalregister.

1. Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning i konsolen, inget krav på persistent lagring)
2. Programmet skall kunna skriva ut registret i en konsol.

# Uppgift 1

    Vilka klasser bör ingå i programmet?
    class Employee
    class EmployeeList
    class Program

# Uppgift 2

    Vilka attribut och metoder bör ingå i dessa klasser?
    attribut Employee: string name och int salary
    attribut EmployeeList: List<Employee> employees
    metoder Employee: string ToString() som returneras anställdas namn och lön
    metoder EmployeeList: void AddEmployee(string name, int salary) som lägger till en anställd i listan
    metoder EmployeeList: void PrintAllEmployees() som skriver ut alla anställda i listan

# Uppgift 3

    Skriv programmet
