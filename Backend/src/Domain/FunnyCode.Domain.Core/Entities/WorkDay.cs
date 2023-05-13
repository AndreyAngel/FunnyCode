namespace FunnyCode.Domain.Core.Entities;

public class WorkDay : BaseEntity
{
    public DateOnly Date { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }
}
