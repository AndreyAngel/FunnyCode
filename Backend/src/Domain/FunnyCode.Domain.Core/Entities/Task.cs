namespace FunnyCode.Domain.Core.Entities;

public class Task : BaseEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public List<UserProfile> Users { get; set; }

    public TaskStatus Status { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}
