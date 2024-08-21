using System.ComponentModel.DataAnnotations;

namespace CapHead.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    [MaxLength]
    public string Name { get; set; }
    
    public string ImageUrl { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}