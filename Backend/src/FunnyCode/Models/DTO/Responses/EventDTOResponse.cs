namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for specific event request
/// </summary>
public class EventDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public string Location { get; set; }

    public List<SubdivisionDTOResponse> Subdivisions { get; set; } = new();

    public List<DivisionDTOResponse> Divisions { get; set; } = new();

}