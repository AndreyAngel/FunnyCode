using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Core.Enums;

namespace FunnyCode.Services.Interfaces.Models;

public class UserFiltersModel
{
    public string? TeamName { get; set; }

    public string? DivisionName { get; set; }

    public string? SubdivisionName { get; set; }

    public JobTitle JobTitle { get; set; }

    public Address? WorkAddress { get; set; }

    public RoleInProject? RoleInProject { get; set; }
}
