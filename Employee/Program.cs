class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Anny", "Viky");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary(Position.Manager, 8);
        Console.WriteLine($"Salary: {salary} uah");

        Console.ReadLine();
    }
}
