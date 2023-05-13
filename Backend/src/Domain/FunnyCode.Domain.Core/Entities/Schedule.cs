namespace FunnyCode.Domain.Core.Entities;

/// <summary>
/// Helper entity of schedule(график работы)
/// </summary>
public class Schedule : BaseEntity
{
    public List<WorkDay> Schedules { get; set; }
}
