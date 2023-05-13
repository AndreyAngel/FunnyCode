using FunnyCode.Models.DTO.Responses.Project;
using FunnyCode.Models.DTO.Responses.UserProfile;

namespace FunnyCode.Models.DTO.Responses.CompanyStructure;
/// <summary>
/// Response information for specific team request
/// </summary>
public class TeamDTOResponse
{
    public string Name { get; set; }

    public List<UserProfileListDTOResponse> Users { get; set; } = new();

    public UserProfileDTOResponse Leader { get; set; }

    public ProjectDTOResponse? Project { get; set; }

}
