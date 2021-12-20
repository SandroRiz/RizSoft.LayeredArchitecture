namespace RizSoft.LayeredArchitecture.DAL.EfCore;

// derive from BaseRepositoryWithFactory for Blazor Server Side to avoid concurrency issues;
public class EmployeeRepository : BaseRepositoryWithFactory<Employee, int>, IEmployeeRepository
{
    public EmployeeRepository(IDbContextFactory<NorthwindDbContext> factory) : base(factory)
    {
    }

}

// for other type of projects (API, MVC/Razor Pages) you can use a "normal" DbContext and you can derive from BaseRepository
//public class EmployeeRepository : BaseRepository<Employee, int>, IEmployeeRepository
//{
//    public EmployeeRepository(NorthwindDbContext context) : base(context)
//    {
//    }

//}
