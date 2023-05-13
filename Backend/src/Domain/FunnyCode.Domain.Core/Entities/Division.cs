namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Specific division entity 
/// </summary>
public class Division : BaseEntity
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public Guid LeaderId { get; set; }

    public UserProfile? Leader { get; set; }

    public List<Subdivision> Subdivisions { get; set; } = new();
    
    public List<UserProfile> Users { get; set; } = new();
}
