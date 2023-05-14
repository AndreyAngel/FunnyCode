namespace FunnyCode.Models.DTO.Responses.UserProfile;

public class UserProfileDivisionDTOResponse
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public UserProfileListDTOResponse? Leader { get; set; }
}
