namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for user contacts request
/// </summary>
public class ContactsDTOResponse
{
    public string Email { get; set; }

    public string? MobilePhoneNumber { get; set; }

    public string WorkPhoneNumber { get; set; }

    public string RocketChatLogin { get; set; }
}
