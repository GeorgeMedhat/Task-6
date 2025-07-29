using BusinessLogic.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository
    {
        // Create
        Task<EntityEntry<Product>> AddAsync(Product product);

        // Read
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);

        // Update
        Task<bool> UpdateAsync(Product product);

        // Delete
        void Delete(Product category);
    }
}

