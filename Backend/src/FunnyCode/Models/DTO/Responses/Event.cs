namespace FunnyCode.Domain.Core.Entities;

public class Event
{
    public Guid Id { get; set; }
    public List<Subdivision> Subdivisions { get; set; } = new();
    public List<Division> Divisions { get; set; } = new();
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string Name { get; set; }    

}