namespace FunnyCode.Domain.Core.Entities;

public class SubdivisionDTOResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public Guid DivisionId { get; set; }

    public DivisionDTOResponse? Division { get; set; }

    public List<TeamDTOResponse> Teams { get; set; } = new();
}