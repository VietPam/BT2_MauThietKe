using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Models;

public abstract class Employee : IEmployee
{
    protected string name;
    protected double salary;

    public string GetName()
    {
        return name;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public abstract double CalculateSalary();

    public abstract void Manage(IEmployee employee);

    public abstract List<IEmployee> GetManagedEmployees();
}
