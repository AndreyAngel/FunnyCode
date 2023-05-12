using System.Diagnostics.Contracts;

namespace FunnyCode.Domain.Core.Entities;

public class UserProfile
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string IsAvailable { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string WorkAdress { get; set; }
    public string inTeamRole { get; set; }
    public string inProjectRole { get; set; }
    public Guid TeamId { get; set; }

    public Team? Team { get; set; }
    

}
