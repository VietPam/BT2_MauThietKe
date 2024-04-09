using BT2_MauThietKe.Models.Contract;

namespace BT2_MauThietKe.Decorator;
class PromotionDecorator : IEmployee
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
        // Tính toán lương cho vai trò mới
        return 0; // Ví dụ
    }

    public void Manage(IEmployee employee)
    {
        // Quản lý nhân viên trong vai trò mới
    }

    public List<IEmployee> GetManagedEmployees()
    {
        // Trả về danh sách nhân viên được quản lý trong vai trò mới
        return new List<IEmployee>();
    }
}