using System;
using partial_views.Models;

namespace partial_views.Services.Interfaces
{
    public interface IExpertService
    {
        Task<List<Expert>> GetExpertsAsync();
    }

}

