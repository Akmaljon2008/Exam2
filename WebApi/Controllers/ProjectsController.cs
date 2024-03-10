using Domain.Models;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ProjectsController : ControllerBase
{
    private readonly ProjectService _projectService;

    public ProjectsController()
    {
        _projectService = new ProjectService();
    }

    [HttpGet("get-projects")]
    public async Task<List<Projects>> GetProjectsAsync()
    {
        return await _projectService.GetProjectsAsync();
    }

    [HttpPost("add-project")]
    public async Task AddProjectAsync([FromForm] Projects project)
    {
        await _projectService.AddProjectAsync(project);
    }

    [HttpPut("update-project")]
    public async Task UpdateProjectAsync([FromForm] Projects project)
    {
        await _projectService.UpdateProjectAsync(project);
    }

    [HttpDelete("delete-project")]
    public async Task DeleteProjectAsync(int id)
    {
        await _projectService.DeleteProjectAsync(id);
    }

    [HttpGet("get-counts")]
    public async Task<List<TaskCounts>> GetTasksCountsAsync(string status)
    {
        return await _projectService.GetTasksCountsAsync(status);
    }
} 