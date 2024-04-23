using ConsoleApp1;

Console.WriteLine("Cześć Nikodem");


Employee employee1 = new Employee("Nikodem", "Krawiec", 21);
Employee employee2 = new Employee("Przemek", "Mazur", 33);
Employee employee3 = new Employee("Karolina", "Mazur", 30);
Employee employee4 = new Employee("Roman", "Dąb", 19);

employee1.AddScore(10);
employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(6);

employee2.AddScore(0);
employee2.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(4);

employee3.AddScore(0);
employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(8);

employee4.AddScore(1);
employee4.AddScore(3);
employee4.AddScore(5);
employee4.AddScore(7);
employee4.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4,
};


var maxResult = 0;
Employee EmployeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        EmployeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najlepszy pracownik");
Console.WriteLine("Imię:" + EmployeeWithMaxResult.Name);
Console.WriteLine("Nazwisko:" + EmployeeWithMaxResult.Surname);
Console.WriteLine("Wiek:" + EmployeeWithMaxResult.Age);
Console.WriteLine("Wynik" + EmployeeWithMaxResult.Result);
