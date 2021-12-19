using Microsoft.AspNetCore.Components;

namespace RizSoft.LayeredArchitecture.BlazorServer.Pages
{
    public partial class Index
    {       
        
        [Inject] public IEmployeeService EmployeeService { get; set; }
         public List<Employee> Employees { get; set; }

      
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            Employees = await EmployeeService.ListAsync();
        }
    }
}