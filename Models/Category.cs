using CapHead.JoinTables;

namespace CapHead.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

    private ICollection<ProductCategory> ProductCategories { get; set; }
}