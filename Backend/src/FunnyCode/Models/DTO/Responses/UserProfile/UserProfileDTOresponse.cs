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

    public VacationDTOResponse? CurrentVacation { get; set; }

    public DateOnly NextVacationStartDate { get; set; }

    public int? CountProjects { get; set; }

    public int? CountTasks { get; set; }

    public int? CountTeamUsers { get; set; }
}
