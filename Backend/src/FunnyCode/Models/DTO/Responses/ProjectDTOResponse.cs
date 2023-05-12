namespace FunnyCode.Domain.Core.Entities;

public class ProjectDTOResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public List<TeamDTOResponse> Teams { get; set; } = new();
}
