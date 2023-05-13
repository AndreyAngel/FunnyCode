using FunnyCode.Models.DTO.Responses.UserProfile;

namespace FunnyCode.Models.DTO.Responses.CompanyStructure;
/// <summary>
/// Response information for specific Subdivision request
/// </summary>
public class SubdivisionDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public string? Division { get; set; }

    public List<TeamListDTOResponse> Teams { get; set; } = new();

    public List<UserProfileListDTOResponse> Users { get; set; } = new();
}