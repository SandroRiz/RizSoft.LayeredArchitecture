using RizSoft.LayeredArchitecture.Domain.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;

namespace RizSoft.LayeredArchitecture.BlazorServer.Shared;

public partial class EmployeeCard
{

    [Inject] public IEmployeeService EmployeeService { get; set; }

    [Parameter]
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Employee = await EmployeeService.GetEmployeeCardAsync(EmployeeId);
    }



}
