namespace FunnyCode.Domain.Core.Entities;

public class Division : BaseEntity
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public List<Subdivision> Subdivisions { get; set; } = new();

    public List<Event> Events { get; set; } = new();
}
