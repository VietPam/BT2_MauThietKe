using BT2_MauThietKe.Factory.Contract;
using BT2_MauThietKe.Models;
using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Factory;
class AssistantFactory : IEmployeeFactory
{
    public IEmployee CreateEmployee()
    {
        return new Assistant();
    }
}