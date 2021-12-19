namespace RizSoft.LayeredArchitecture.DAL.EfCore;
public class EmployeeRepository : BaseRepository<Employee, int>, IEmployeeRepository
{
    
    public EmployeeRepository(IDbContextFactory<NorthwindDbContext> factory) : base(factory)
    {
    }

}

