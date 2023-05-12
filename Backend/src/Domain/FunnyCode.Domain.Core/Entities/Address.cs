namespace FunnyCode.Domain.Core.Entities;

public class Address : BaseEntity
{
    public string Region { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string NumberOfHome { get; set; }

    public string? PostalCode { get; set; }
}
