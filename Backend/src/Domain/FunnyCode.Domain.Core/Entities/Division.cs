namespace FunnyCode.Domain.Core.Entities;

public class Division
{
    public Guid Id { get; set; }
    public List<Subdivision> Subdivisions { get; set; } = new();
    public List<Event> Events { get; set; } = new();
}
