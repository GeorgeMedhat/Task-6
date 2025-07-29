using BusinessLogic.Models;
using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EntityEntry<Product>> AddAsync(Product product)
        {
            return await _context.Products.AddAsync(product);
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Where(c => c.markedAsDeleted != true).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            var prod = await GetByIdAsync(product.id);

            if (prod == null)
                return false;

            prod.title = product.title;
            prod.price = product.price;
            prod.description = product.description;
            prod.author = product.author;
            prod.categoryId = product.categoryId;


            _context.Update(prod);
            return true;
        }
    }
}
