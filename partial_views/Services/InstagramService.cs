using System;
using Microsoft.EntityFrameworkCore;
using partial_views.Data;
using partial_views.Models;
using partial_views.Services.Interfaces;

namespace partial_views.Services
{
	public class InstagramService : IInstagramService
    {
        private readonly AppDbContext _context;
        public InstagramService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Instagram>> GetInstagramAsync()
        {
            return await _context.Instagrams.Where(m => !m.SoftDeleted).ToListAsync();
        }

    }
}

