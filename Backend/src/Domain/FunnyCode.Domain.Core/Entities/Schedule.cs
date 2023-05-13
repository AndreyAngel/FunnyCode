namespace FunnyCode.Domain.Core.Entities;

/// <summary>
/// График работы
/// </summary>
public class Schedule : BaseEntity
{
    public List<WorkDay> Schedules { get; set; }
}
