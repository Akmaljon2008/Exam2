using System.Diagnostics;
using Dapper;
using Domain.Models;
using Infrastracture.DataContext;

namespace Infrastracture.Services;

public class ProjectService
{
    private readonly DapperContext _db;

    public ProjectService()
    {
        _db = new DapperContext();
    }

    public async Task<List<Projects>> GetProjectsAsync()
    {
        var sql = "select * from Project";
        var res = await _db.Connection().QueryAsync<Projects>(sql);
        return res.ToList();
    }

    public async Task AddProjectAsync(Projects project)
    {
        var sql =
            "insert into Project(Name,Description,StartDate,EndDate)values (@Name,@Description,@StartDate,@EndDate)";
        await _db.Connection().ExecuteAsync(sql, project);
    }

    public async Task UpdateProjectAsync(Projects project)
    {
        var sql =
            "update Project set Name = @Name ,Description = @Desription,StartDate = @StartDate,EndDate = @EndDate";
        await _db.Connection().ExecuteAsync(sql, project);
    }

    public async Task DeleteProjectAsync(int id)
    {
        var sql = "delete from Project where id = @id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }

    public async Task<List<TaskCounts>> GetTasksCountsAsync(string status)
    {
        
        var sql = "select t.Title, count(t.id) as TaskCount from tasks as t group by t.Title";
        var sql1 = "select count(t.Status) as ComplitedTasks from tasks as t where t.Status = @status";
        var All = await _db.Connection().QueryAsync<TaskCounts>(sql);
        var ComlitedTask = await _db.Connection().QueryAsync<TaskCounts>(sql1, new { Status = status });
        All = All.ToList();
        ComlitedTask = ComlitedTask.ToList();
        var res = new List<TaskCounts>();
        
        res.AddRange(All);
        res.AddRange(ComlitedTask);
        return res;
    }
}