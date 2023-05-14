using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Responses.UserProfile;
/// <summary>
/// Response information for specific user work space request
/// </summary>
public class WorkSpaceDTOResponse
{
    public UserProfileDivisionDTOResponse Division { get; set; }

    public string Subdivision { get; set; }

    public Guid TeamId { get; set; }

    public JobTitleDTO JobTitle { get; set; }

    public RoleInProjectDTO? Role { get; set; }

    public AddressDTO? WorkAddress { get; set; }

    /// <summary>
    /// Удалёнка?
    /// </summary>
    public bool Remotely { get; set; }
}
