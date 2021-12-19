
namespace RizSoft.LayeredArchitecture.Services;

public class EmployeeService : BaseService<Employee, int>, IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    
    public EmployeeService(IEmployeeRepository repository) : base(repository)
    {
        _repository = repository; 
    }

    //sample of Process in Service Layer
    public async Task<List<Employee>> ListAsyncWithoutPhoto()
    {
        var employees = await _repository.ListAsync();
        foreach (var emp in employees)
        {
            emp.PhotoPath = emp.PhotoPath.Replace("accweb", "myDomain");
        }
        return employees;   
    }
}

