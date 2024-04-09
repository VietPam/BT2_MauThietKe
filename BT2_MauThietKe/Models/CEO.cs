using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Models;

public class CEO : Employee
{
    private static CEO instance;

    private CEO() { }

    public static CEO GetInstance()
    {
        if (instance == null)
        {
            instance = new CEO();
        }
        return instance;
    }

    public override double CalculateSalary()
    {
        return 0;
    }

    public override void Manage(IEmployee employee)
    {
    }

    public override List<IEmployee> GetManagedEmployees()
    {
        return new List<IEmployee>();
    }
}
