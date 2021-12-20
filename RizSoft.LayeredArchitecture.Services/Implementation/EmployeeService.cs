
namespace RizSoft.LayeredArchitecture.Services;

public class EmployeeService : BaseService<Employee, int>, IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository) : base(repository)
    {
        _repository = repository;
    }

    //sample of Process in Service Layer
       public async Task<Employee> GetEmployeeCardAsync(int employeeId)
    {
        var employee = await _repository.GetAsync(employeeId);

        if (employeeId == 2 || employeeId == 5 ||employeeId == 6)
            employee.PhotoPath = "/images/man.jpg";
        else
            employee.PhotoPath = "/images/woman.jpg";

        return employee;
    }
}

