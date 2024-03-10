namespace Domain.Models;

public class Tasks
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int AssignedTo { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; }
}