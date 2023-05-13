namespace FunnyCode.Domain.Core.Entities;
/// <summary>
/// Helper entity for schedule(сущность рабочего дня)
/// </summary>
public class WorkDay : BaseEntity
{
    public DateOnly Date { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }
}
