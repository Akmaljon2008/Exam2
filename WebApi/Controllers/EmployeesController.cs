using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly EmployeeService _employeeService;

    public EmployeesController()
    {
        _employeeService = new EmployeeService();
    }

    [HttpGet("get-employees")]
    public async Task<List<Employees>> GetEmployeesAsync()
    {
        return await _employeeService.GetEmployeesAsync();
    }

    [HttpPost("add-employee")]
    public async Task AddEmployeeAsync([FromForm]Employees employee)
    {
        await _employeeService.AddEmployeeAsync(employee);
    }

    [HttpPut("update-employee")]
    public async Task UpdateEmployeeAsync([FromForm]Employees employee)
    {
        await _employeeService.UpdateEmployeeAsync(employee);
    }

    [HttpDelete("delete-employee")]
    public async Task DeleteEmployee(int id)
    {
        await _employeeService.DeleteEmployeeAsync(id);
    }

    [HttpGet("get-by-task-id")]
    public async Task<List<Employees>> GetEmployeesByTaskIdAsync(int id)
    {
        return await _employeeService.GetEmployeesByTaskIdAsync(id);
    }
    
    
}