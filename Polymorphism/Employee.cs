namespace Polymorphism
{
    public abstract class Employee
    {
    public string Name;
    public abstract double GetMonthlySalary();

    public Employee(string name)
    {
        Name = name;
    }
    }
}