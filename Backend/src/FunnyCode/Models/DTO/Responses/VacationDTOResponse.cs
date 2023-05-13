using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for specific user vacation info request
/// </summary>
public class VacationDTOResponse 
{
    public DateOnly StartData { get; set; }

    public DateOnly? EndData { get; set; }

    public VacationType Type { get; set; }

    /// <summary>
    /// Контакты заместителя
    /// </summary>
    public ContactsDTOResponse? DeputyContacts { get; set; }

}
