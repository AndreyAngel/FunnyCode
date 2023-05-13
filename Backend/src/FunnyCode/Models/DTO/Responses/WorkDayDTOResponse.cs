namespace FunnyCode.Models.DTO.Responses;

public class WorkDayDTOResponse
{
    public DateOnly Date { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }
}
