using Dapper;
using Domain.Models;
using Infrastracture.DataContext;

namespace Infrastracture.Services;

public class EmployeeService
{
    private readonly DapperContext _db;

    public EmployeeService()
    {
        _db = new DapperContext();
    }

    public async Task<List<Employees>> GetEmployeesAsync()
    {
        var sql = "select * from Employees";
        var res = await _db.Connection().QueryAsync<Employees>(sql);
        return res.ToList();
    }

    public async Task AddEmployeeAsync(Employees employee)
    {
        var sql = "insert into Employees(FullName,Department)values (@FullName,@Department)";
        await _db.Connection().ExecuteAsync(sql, employee);
    }

    public async Task UpdateEmployeeAsync(Employees employee)
    {
        var sql = "update Employees set FullName = @FullName , Department = @Department where id = @id";
        await _db.Connection().ExecuteAsync(sql, employee);
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        var sql = "delete from Employees where id = @id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }

    public async Task<List<Employees>> GetEmployeesByTaskIdAsync(int id)
    {
        var sql =
            "select e.Id , e.FullName,e.Department from tasks as t join Employees as e on e.Id = t.AssignedTo where t.id = @id";
        var res = await _db.Connection().QueryAsync<Employees>(sql, new { Id = id });
        return res.ToList();
    }
}