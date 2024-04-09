using BT2_MauThietKe.Factory.Contract;
using BT2_MauThietKe.Models;
using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Factory;
class MarketingStaffFactory : IEmployeeFactory
{
    public IEmployee CreateEmployee()
    {
        return new MarketingStaff();
    }
}