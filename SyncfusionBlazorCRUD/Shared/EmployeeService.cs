using SyncfusionBlazorCRUD.Shared;

public class EmployeeService
{
    private List<Employee> employees = new List<Employee>
    {
        new Employee { Id=1, Name="John Doe", Title="Manager", Age=35 },
        new Employee { Id=2, Name="Jane Smith", Title="Developer", Age=28 }
    };

    public List<Employee> GetEmployees() => employees;

    public void AddEmployee(Employee emp)
    {
        emp.Id = employees.Max(e => e.Id) + 1;
        employees.Add(emp);
    }

    public void UpdateEmployee(Employee emp)
    {
        var existing = employees.FirstOrDefault(e => e.Id == emp.Id);
        if (existing != null)
        {
            existing.Name = emp.Name;
            existing.Title = emp.Title;
            existing.Age = emp.Age;
        }
    }

    public void DeleteEmployee(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);
        if (emp != null)
            employees.Remove(emp);
    }
}