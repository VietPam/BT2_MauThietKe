using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Models;
class MarketingStaff : Employee
{
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