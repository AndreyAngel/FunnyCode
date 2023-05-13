using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Requests
{
    public class UsersFilterDTORequest
    {
        public string? Address { get; set; }
        public string? TeamName { get; set; }
        public string? DivisionName { get; set; }
        public string? SubDivisionName { get; set; }
        public string? JobTitle { get; set; }
        public RoleInProject? RoleInProject { get; set; }


    }
}
