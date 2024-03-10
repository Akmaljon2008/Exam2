using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly TasksService _tasksService;

    public TasksController()
    {
        _tasksService = new TasksService();
    }

    [HttpGet("get-tasks")]
    public async Task<List<Tasks>> GetTasksAsync()
    {
        return await _tasksService.GetTasksAsync();
    }

    [HttpPost("add-task")]
    public async Task UpdateTask([FromForm] Tasks task)
    {
        await _tasksService.AddTaskAsync(task);
    }

    [HttpPut("update-task")]
    public async Task UpdateTaskAsync([FromForm] Tasks task)
    {
        await _tasksService.UpdateTaskAsync(task);
    }

    [HttpDelete("delete-task")]
    public async Task DeleteTask([FromForm] int id)
    {
        await _tasksService.DeleteTaskAsync(id);
    }

    [HttpGet("get-task-by-project-id")]
    public async Task<List<Tasks>> GetTasksByProjectIdAsync(int id)
    {
        return await _tasksService.GetTasksByProjectIdAsync(id);
    }

    [HttpGet("get-tasks-by-employee-id")]
    public async Task<List<Tasks>> GetTasksByEmployeeIdAsync(int id)
    {
        return await _tasksService.GetTasksByEmployeeIdAsync(id);
    }
}