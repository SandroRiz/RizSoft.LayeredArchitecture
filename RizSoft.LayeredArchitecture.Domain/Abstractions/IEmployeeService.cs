
namespace RizSoft.LayeredArchitecture.Domain.Abstractions;

public interface IEmployeeService : IBaseService<Employee, int>
{

    Task<Employee> GetEmployeeCardAsync(int employeeId);
}

