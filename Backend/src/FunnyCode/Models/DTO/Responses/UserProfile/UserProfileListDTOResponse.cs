using FunnyCode.Models.DTO.Responses;

namespace FunnyCode.Models.DTO.Responses.UserProfile;

/// <summary>
/// Response information for user profiles list request
/// </summary>
public class UserProfileListDTOResponse : BaseEntityDTOResponse
{
    public string Name { get; set; }
}
