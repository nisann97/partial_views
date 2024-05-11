using System;
using Microsoft.EntityFrameworkCore;
using partial_views.Data;
using partial_views.Models;
using partial_views.Services.Interfaces;

namespace partial_views.Services
{
    public class CategoryService : ICategoriyService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}

