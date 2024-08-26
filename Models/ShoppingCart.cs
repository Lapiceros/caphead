

using System.ComponentModel.DataAnnotations;

namespace CapHead.Models;

public class ShoppingCart
{
    public int ShoppingCartId { get; set; }
    public string? UserId { get; set; }
    public DateTime InitDate { get; set; }
    [MaxLength(10)]
    public string? Status { get; set; }
    public AppUser? User { get; set; }
    public ICollection<Items>? ItemsCollection { get; set; }
}