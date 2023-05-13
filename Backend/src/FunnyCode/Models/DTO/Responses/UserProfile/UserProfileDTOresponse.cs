namespace FunnyCode.Models.DTO.Responses.UserProfile;
/// <summary>
/// Response information for specific user profile request
/// </summary>
public class UserProfileDTOResponse
{
    public string Name { get; set; }

    public DateOnly BirthDate { get; set; }

    public ContactsDTOResponse? Contacts { get; set; }

    public WorkSpaceDTOResponse? WorkSpace { get; set; }

    public ScheduleDTOResponse? Schedule { get; set; }

    public List<VacationDTOResponse> Vacations { get; set; }
}
