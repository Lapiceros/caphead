using CapHead.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CapHead.JoinTables;

public class ProductCategory
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}