using Dapper;
using Domain.Models;
using Infrastracture.DataContext;

namespace Infrastracture.Services;

public class TasksService
{
    private readonly DapperContext _db;

    public TasksService()
    {
        _db = new DapperContext();
    }

    public async Task<List<Tasks>> GetTasksAsync()
    {
        var sql = "select * from tasks";
        var res = await _db.Connection().QueryAsync<Tasks>(sql);
        return res.ToList();
    }

    public async Task AddTaskAsync(Tasks task)
    {
        var sql =
            "insert into tasks(ProjectId,Title,Description,AssignedTo,DueDate,Status)values (@ProjectId,@Title,@Description,@AssignedTo,@DueDate,@Status)";
        await _db.Connection().ExecuteAsync(sql, task);
    }

    public async Task UpdateTaskAsync(Tasks task)
    {
        var sql =
            "update tasks set ProjectId = @ProjectId,Title = @Title,Description = @Descripion,AssignedTo = @AssignedTo,DueDate = @DueDate,Status = @Status";
        await _db.Connection().ExecuteAsync(sql, task);
    }

    public async Task DeleteTaskAsync(int id)
    {
        var sql = "delete from tasks where Id = @id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }

    public async Task<List<Tasks>> GetTasksByEmployeeIdAsync(int id)
    {
        var sql = "select * from tasks where AssignedTo = @Id";
        var res = await _db.Connection().QueryAsync<Tasks>(sql, new { Id = id });
        return res.ToList();
    }
    
    public async Task<List<Tasks>> GetTasksByProjectIdAsync(int id)
    {
        var sql = "select * from tasks where ProjectId = @Id";
        var res = await _db.Connection().QueryAsync<Tasks>(sql, new { Id = id });
        return res.ToList();
    }
}