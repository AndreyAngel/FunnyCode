namespace FunnyCode.Domain.Core.Entities;

public class TeamDTOResponse
{
    public Guid Id { get; set; }
    
    public Guid ProjectId { get; set; }

    public ProjectDTOResponse? Project { get; set; }

    public List<UserProfileDTOresponse> Users { get; set; } = new();

}
