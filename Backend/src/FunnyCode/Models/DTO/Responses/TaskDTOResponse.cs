namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for specific task request
/// </summary>
public class TaskDTOResponse 
{
    public string Name { get; set; }

    public string Description { get; set; }

    public ProjectDTOResponse? Project { get; set; }

    public List<UserProfileDTOResponse> Users { get; set; }

    public TaskStatus Status { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}
