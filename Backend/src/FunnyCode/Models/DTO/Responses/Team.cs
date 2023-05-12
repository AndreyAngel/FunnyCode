namespace FunnyCode.Domain.Core.Entities;

public class Team
{
    public Guid Id { get; set; }
    public List<UserProfile> Users { get; set; } = new();
    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

}
