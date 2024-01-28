using AutoMapper;
using Catalog.API.Core;
using Catalog.API.Data;
using Catalog.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
        private readonly CatalogContext _context;

        public ProductRepository(CatalogContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.products.ToListAsync();
                            
        }
        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
           return await _context.products.Where(p => p.Name == name).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            return await _context.products.Where(p => p.Category == categoryName).ToListAsync();
        }

        public async Task CreateProduct(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Result<Product>> UpdateProduct(Product product)
        {
            var productId = await _context.products.FindAsync(product.Id);

            if (productId == null) return null;

            _mapper.Map(product, productId);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return Result<Product>.Failure("Failed to update product");

            return Result<Product>.Success(product);

        }

        public async Task<Result<Product>> DeleteProduct(Guid id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null) return null;

            _context.Remove(product);
            var res = await _context.SaveChangesAsync() > 0;
            if (!res) return Result<Product>.Failure("Failed to delete product");
            return Result<Product>.Success(product);
        }

        public async Task<Result<Product>> GetProduct(Guid id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null) return Result<Product>.Failure("Not Found");

            return Result<Product>.Success(product);
        }
    }
}
