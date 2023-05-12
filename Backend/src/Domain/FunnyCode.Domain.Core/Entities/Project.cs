namespace FunnyCode.Domain.Core.Entities;

public class Project
{
    public Guid Id { get; set; }
    public List<Team> Teams { get; set; } = new();
    public string Name { get; set; }
    public string Description { get; set; }
}
