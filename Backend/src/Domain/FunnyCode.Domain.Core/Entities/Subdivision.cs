namespace FunnyCode.Domain.Core.Entities;

public class Subdivision : BaseEntity
{
    public Guid DivisionId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Division? Division { get; set; }

    public List<Team> Teams { get; set; } = new();

    public List<UserProfile> Users { get; set; } = new();
}