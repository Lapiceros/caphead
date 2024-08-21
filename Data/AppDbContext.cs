using CapHead.Models;
using Microsoft.EntityFrameworkCore;

namespace CapHead.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}