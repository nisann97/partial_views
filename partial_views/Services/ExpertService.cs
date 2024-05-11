using System;
using Microsoft.EntityFrameworkCore;
using partial_views.Data;
using partial_views.Models;
using partial_views.Services.Interfaces;

namespace partial_views.Services
{
	public class ExpertService : IExpertService
	{
        private readonly AppDbContext _context;
        public ExpertService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Expert>> GetExpertsAsync()
        {
            return await _context.Experts.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}



