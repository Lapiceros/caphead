using Microsoft.AspNetCore.Identity;

namespace CapHead.Models;

public class AppUser : IdentityUser
{
    public string UserName { get; set; }
    public ICollection<ShoppingCart> ShoppingCart { get; set; }
    public ICollection<Order> Orders { get; set; }
}
