using FunnyCode.Models.DTO.Enums;

namespace FunnyCode.Models.DTO.Responses;

public class VacationDTOResponse 
{
    public DateOnly StartData { get; set; }

    public DateOnly? EndData { get; set; }

    public VacationType Type { get; set; }

    /// <summary>
    /// Контакты заместителя
    /// </summary>
}
