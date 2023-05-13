using FunnyCode.Models.DTO.Responses.CompanyStructure;

namespace FunnyCode.Models.DTO.Responses.Project;
/// <summary>
/// Response information for specific project request
/// </summary>
public class ProjectDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public List<TaskDTOResponse> Tasks { get; set; } = new();

    public List<DivisionListDTOResponse> Divisions { get; set; } = new();
}
