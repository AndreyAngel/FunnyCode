namespace FunnyCode.Models.DTO.Responses;
public class DivisionDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public List<SubDivisionsListDTOResponse> Subdivisions { get; set; } = new();
}
