namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for specific team request
/// </summary>
public class TeamDTOResponse
{
    public List<UserProfileListDTOResponse> Users { get; set; } = new();

}
