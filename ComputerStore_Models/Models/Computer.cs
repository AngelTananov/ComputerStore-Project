
namespace ComputerStore_Models.Models;

public record Computer
{
    public int Id { get; set; }

    public string CPU { get; set; }

    public string Memory { get; set; }

    public DateTime ReleaseDate { get; set; }

    public int CustomerId { get; set; }
    
