namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for specific project request
/// </summary>
public class ProjectDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public List<TaskDTOResponse> Tasks { get; set; }

    public List<TeamDTOResponse> Teams { get; set; } = new();
}
