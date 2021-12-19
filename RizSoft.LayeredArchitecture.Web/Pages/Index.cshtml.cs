using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RizSoft.LayeredArchitecture.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<IndexModel> _logger;


        public List<Employee> Employees { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IEmployeeService EmployeeService)
        {
            _logger = logger;
            _employeeService = EmployeeService;

        }

        public async Task<IActionResult> OnGetAsync()
        {
            Employees = await _employeeService.ListAsync();
            return Page();
        }
    }
}