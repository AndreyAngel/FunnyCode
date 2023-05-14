namespace FunnyCode.Domain.Core.Entities;

/// <summary>
/// Specific subdivision entity 
/// </summary>
public class Subdivision : BaseEntity
{
    public string Name { get; set; }

    public Guid LeaderId { get; set; }

    public UserProfile? Leader { get; set; }

    public string Description { get; set; }

    public Guid DivisionId { get; set; }

    public Division? Division { get; set; }

    public List<Team> Teams { get; set; } = new();

    public List<UserProfile> Users { get; set; } = new();

    public List<Project> Projects { get; set; } = new();

    public override string ToString()
    {
        return Name;
    }
}