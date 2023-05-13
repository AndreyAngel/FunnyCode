namespace FunnyCode.Domain.Core.Entities;

public class Contacts : BaseEntity
{
    public string Email { get; set; }

    public string? MobilePhoneNumber { get; set; }

    public string WorkPhoneNumber { get; set; }

    public string RocketChatLogin { get; set; }
}
