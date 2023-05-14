using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Responses.UserProfile;

/// <summary>
/// Response information for user profiles list request
/// </summary>
public class UserProfileListDTOResponse : BaseEntityDTOResponse
{
    public string Name { get; set; }

    public JobTitleDTO JobTitle { get; set; }
}
