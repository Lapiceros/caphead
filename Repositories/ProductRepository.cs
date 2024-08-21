using CapHead.Data;
using CapHead.DTOs;
using CapHead.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapHead.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> AddNewProduct(Product newProduct)
    {
        _context.Add(newProduct);
        await _context.SaveChangesAsync();
        return newProduct;
    }

    public async Task<Product> UpdateProduct(Product updatedProduct)
    {
        _context.Update(updatedProduct);
        await _context.SaveChangesAsync();
        return updatedProduct;
    }

    public async Task DeleteProduct(int id)
    {
        await _context.Products.Where(x => x.ProductId == id).ExecuteDeleteAsync();
    }
}