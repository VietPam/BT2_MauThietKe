using BT2_MauThietKe.Factory.Contract;
using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Models;
class Company
{
    private CEO CEO;
    private IEmployeeFactory employeeFactory;
    private List<IEmployee> employeeList;
    public CEO GetCEO()
    {
        return CEO;
    }
    public void SetCEO(CEO ceo)
    {
        CEO = ceo;
    }
    public void SetEmployeeFactory(IEmployeeFactory factory)
    {
        employeeFactory = factory;
    }

    public void AddEmployee()
    {
        IEmployee employee = employeeFactory.CreateEmployee();
        employeeList.Add(employee);
    }

    public List<IEmployee> GetEmployeeList()
    {
        return employeeList;
    }
}