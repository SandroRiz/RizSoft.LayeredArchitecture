using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace RizSoft.LayeredArchitecture.BlazorWasm.Pages
{
    public partial class Index
    {
        public List<Employee> Employees { get; set; }
        [Inject] public HttpClient Http { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = await Http.GetFromJsonAsync<List<Employee>>("https://localhost:7083/employees");
        }
    }
}