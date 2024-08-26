using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Common;

namespace CapHead.Models;

public class Order
{
    public int OrderId { get; set; }
    public string UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public decimal TotalPrice { get; set; }
    public AppUser User { get; set; }
    public ICollection<Items> ItemsCollection { get; set; }
}