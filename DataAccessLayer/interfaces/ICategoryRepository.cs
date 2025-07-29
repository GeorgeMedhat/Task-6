using BusinessLogic.Models;
using BusinessLogicLayer.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        // Create
        Task<EntityEntry<Category>> AddAsync(Category category);

        // Read
        Task<IEnumerable<Category>> GetAllAsyncWithPagination(PaginationParams paginationParams);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);

        // Update
        Task<bool> UpdateAsync(Category category);

        // Delete
        void Delete(Category category);
    }
}