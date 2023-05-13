namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Specific event entity 
/// </summary>
public class Event : BaseEntity
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public string Location { get; set; }

    public List<Subdivision> Subdivisions { get; set; } = new();

    public List<Division> Divisions { get; set; } = new();
}