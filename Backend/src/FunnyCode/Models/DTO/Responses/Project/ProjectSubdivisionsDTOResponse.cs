namespace FunnyCode.Models.DTO.Responses.Project;

/// <summary>
/// Subdivisions that use at the project
/// </summary>
public class ProjectSubdivisionsDTOResponse : BaseEntityDTOResponse
{
    public string Name { get; set; }

    public List<ProjectTeamsDTOResponse> Teams { get; set; } = new();
}
