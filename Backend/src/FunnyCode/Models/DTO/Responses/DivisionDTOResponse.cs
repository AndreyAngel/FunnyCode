namespace FunnyCode.Domain.Core.Entities;

public class DivisionDTOResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public List<SubdivisionDTOResponse> Subdivisions { get; set; } = new();
}
