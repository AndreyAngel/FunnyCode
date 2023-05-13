using FunnyCode.Domain.Core.Enums;

namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Specific user work space entity 
/// </summary>
public class WorkSpace : BaseEntity
{
    public Guid AddressId { get; set; }

    public Address? Address { get; set; }

    public Guid DivisionId { get; set; }

    public Division? Division { get; set; }

    public Guid SubdivisionId { get; set; }

    public Subdivision? Subdivision { get; set; }

    public JobTitle JobTitle { get; set; }

    public Guid? TeamId { get; set; }

    public Team? Team { get; set; }

    public Guid? ProjectId { get; set; }

    public Project? Project { get; set; }

    public RoleInProject? Role { get; set; }

    /// <summary>
    /// Удалёнка?
    /// </summary>
    public bool Remotely { get; set; }
}
