namespace FunnyCode.Models.DTO.Responses.Project;

/// <summary>
/// Divisions that use at the project
/// </summary>
public class ProjectDivisionsDTOResponse : BaseEntityDTOResponse
{
    public string Name { get; set; }

    public List<ProjectSubdivisionsDTOResponse> Subdivisions { get; set; } = new();
}
