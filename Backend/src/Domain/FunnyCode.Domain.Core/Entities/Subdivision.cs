namespace FunnyCode.Domain.Core.Entities;

public class Subdivision
{
    public Guid Id { get; set; }
    public List<Team> Teams { get; set; } = new();
    public List<Event> Evets { get; set; } = new();
}