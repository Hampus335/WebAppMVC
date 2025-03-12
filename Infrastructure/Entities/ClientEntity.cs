using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ClientEntity
{
    
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
}
