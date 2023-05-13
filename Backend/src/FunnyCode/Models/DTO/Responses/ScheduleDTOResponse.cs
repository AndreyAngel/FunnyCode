namespace FunnyCode.Models.DTO.Responses;

/// <summary>
/// Response information for график работы(schedule) request
/// </summary>
public class ScheduleDTOResponse 
{
    public List<WorkDayDTOResponse> Schedules { get; set; }

}
