using FunnyCode.Domain.Core.Enums;

namespace FunnyCode.Domain.Core.Entities;

public class Vacation : BaseEntity
{
    public Guid UserId { get; set; }

    public UserProfile? User { get; set; }

    public DateOnly StartData { get; set; }

    public DateOnly? EndData { get; set; }

    public VacationType Type { get; set; }

    public Guid? DeputyContactsId { get; set; }

    /// <summary>
    /// Контакты заместителя
    /// </summary>
    public Contacts? DeputyContacts { get; set; }
}
