using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Models;

public class PromotionDecorator : IEmployee
{
    private IEmployee employee;
    private string newRole;

    public PromotionDecorator(IEmployee employee, string newRole)
    {
        this.employee = employee;
        this.newRole = newRole;
    }

    public string GetName()
    {
        return employee.GetName();
    }

    public double GetSalary()
    {
        return employee.GetSalary();
    }

    public void SetName(string name)
    {
        employee.SetName(name);
    }

    public void SetSalary(double salary)
    {
        employee.SetSalary(salary);
    }

    public double CalculateSalary()
    {
        return 0;
    }

    public void Manage(IEmployee employee)
    {
    }

    public List<IEmployee> GetManagedEmployees()
    {
        return new List<IEmployee>();
    }
}
