namespace FunnyCode.Domain.Core.Entities;

public class Team : BaseEntity
{
    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public List<UserProfile> Users { get; set; } = new();

}
