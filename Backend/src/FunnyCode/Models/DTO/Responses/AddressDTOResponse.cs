namespace FunnyCode.Models.DTO.Responses;
/// <summary>
/// Response information for adress request
/// </summary>
public class AddressDTOResponse 
{
    public string Region { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string NumberOfHome { get; set; }

    public string? PostalCode { get; set; }
}
