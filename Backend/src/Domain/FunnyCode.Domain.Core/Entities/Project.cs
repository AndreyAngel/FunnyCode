namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Specific project entity 
/// </summary>
public class Project : BaseEntity
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public List<Division> Divisions { get; set; } = new();

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public List<Task> Tasks { get; set; }
}
