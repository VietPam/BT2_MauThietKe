namespace BT2_MauThietKe.Models.Contract;
public interface IEmployee
{
    string GetName();
    double GetSalary();
    void SetName(string name);
    void SetSalary(double salary);
    double CalculateSalary();
    void Manage(IEmployee employee);
    List<IEmployee> GetManagedEmployees();
}
