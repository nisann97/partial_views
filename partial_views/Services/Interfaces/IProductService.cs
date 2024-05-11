using System;
using partial_views.Models;

namespace partial_views.Services.Interfaces
{

        public interface IProductService
        {
            Task<List<Product>> GetAllAsync();
            Task<Product> GetByIdAsync(int id);
        }
    }


