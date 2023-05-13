namespace FunnyCode.Models.DTO.Responses;
public class SubdivisionDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public DivisionDTOResponse? Division { get; set; }

    public List<TeamListDTOResponse> Teams { get; set; } = new();
}