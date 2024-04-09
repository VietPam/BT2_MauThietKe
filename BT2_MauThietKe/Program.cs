using BT2_MauThietKe.Factory;
using BT2_MauThietKe.Factory.Contract;
using BT2_MauThietKe.Models;
using BT2_MauThietKe.Models.Contract;


Company company = new();

CEO ceo = CEO.GetInstance();
company.SetCEO(ceo);

IEmployeeFactory marketingStaffFactory = new MarketingStaffFactory();
IEmployeeFactory productionStaffFactory = new ProductionStaffFactory();
IEmployeeFactory assistantFactory = new AssistantFactory();

company.SetEmployeeFactory(marketingStaffFactory);

company.AddEmployee();

company.SetEmployeeFactory(productionStaffFactory);

company.AddEmployee();

company.SetEmployeeFactory(assistantFactory);

company.AddEmployee();

var existCeo = company.GetCEO();
Console.WriteLine("CEO: " + ceo.GetName());

List<IEmployee> employees = company.GetEmployeeList();
Console.WriteLine("Employee List:");
foreach (Employee employee in employees)
{
    Console.WriteLine("- " + employee.GetName());
}
