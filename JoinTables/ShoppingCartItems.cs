using CapHead.Models;

namespace CapHead.JoinTables;

public class ShoppingCartItems
{
    public int ItemId { get; set; }
    public int ShoppingCartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public ShoppingCart Cart { get; set; }
    public Product Product { get; set; }
}