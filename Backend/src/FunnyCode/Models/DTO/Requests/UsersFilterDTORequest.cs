using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Requests;

public class UsersFilterDTORequest
{
    public string? TeamName { get; set; }

    public string? DivisionName { get; set; }

    public string? SubdivisionName { get; set; }

    public AddressDTO WorkAddress { get; set; }

    public JobTitle JobTitle { get; set; }

    public RoleInProject? RoleInProject { get; set; }
}
