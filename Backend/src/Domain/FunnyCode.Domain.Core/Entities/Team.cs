namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Specific team entity 
/// </summary>
public class Team : BaseEntity
{
    public string Name { get; set; }

    public Guid SubdivisionId { get; set; }

    public Subdivision? Subdivision { get; set; }

    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public UserProfile Leader { get; set; }

    public List<UserProfile> Users { get; set; } = new();

    public List<Project> Projects { get; set; } = new();

    public override string ToString()
    {
        return Name;
    }
}
