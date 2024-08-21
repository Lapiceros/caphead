using AutoMapper;
using CapHead.Data;
using CapHead.DTOs;
using CapHead.Models;
using CapHead.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapHead.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public ProductController(IProductRepository productRepository, IMapper mapper, AppDbContext context)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducDTO>>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            var productsResult = _mapper.Map<IEnumerable<Product>>(products);
            return Ok(productsResult);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProduct(ProducDTO newProduct)
        {
            var product = _mapper.Map<Product>(newProduct);
            await _productRepository.AddNewProduct(product);
            return Ok(product);
        }
        
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id,[FromBody] ProducDTO updateProduct)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _mapper.Map(updateProduct, product);
                await _productRepository.UpdateProduct(product);
                return Ok(updateProduct);
            } 
            return NotFound();
        }
        
    }
}
