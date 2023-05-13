using FunnyCode.Models.DTO.Enums;
using FunnyCode.Models.DTO.Responses.CompanyStructure;
using FunnyCode.Models.DTO.Responses.Project;

namespace FunnyCode.Models.DTO.Responses.UserProfile;
/// <summary>
/// Response information for specific user work space request
/// </summary>
public class WorkSpaceDTOResponse
{
    public AddressDTOResponse? Address { get; set; }

    public DivisionDTOResponse? Division { get; set; }

    public SubdivisionDTOResponse? Subdivision { get; set; }

    public JobTitle JobTitle { get; set; }

    public TeamDTOResponse? Team { get; set; }

    public ProjectDTOResponse? Project { get; set; }

    public RoleInProject? Role { get; set; }

    /// <summary>
    /// Удалёнка?
    /// </summary>
    public bool Remotely { get; set; }
}
