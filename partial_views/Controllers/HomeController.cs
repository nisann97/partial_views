using System;
using partial_views.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using partial_views.Data;
using Microsoft.EntityFrameworkCore;
using partial_views.ViewModels;
using partial_views.Services.Interfaces;

namespace partial_views.Controllers
{
    public class HomeController : Controller
    {
      
            private readonly AppDbContext _context;
            private readonly IProductService _productService;
            private readonly ICategoriyService _categoriyService;
            private readonly IExpertService _expertService;
            private readonly IInstagramService _instagramService;



            public HomeController(AppDbContext context, IProductService productService,
                ICategoriyService categoriyService, IExpertService expertService,
                IInstagramService instagramService)
            {
                _context = context;
                _productService = productService;
                _categoriyService = categoriyService;
                _expertService = expertService;
                _instagramService = instagramService;



            }
            public async Task<IActionResult> Index()
            {
                List<Slider> sliders = await _context.Sliders.ToListAsync();
                SliderInfo slidersInfo = await _context.SliderInfos.FirstOrDefaultAsync();
                List<Category> categories = await _categoriyService.GetCategoriesAsync();
                List<Product> products = await _productService.GetAllAsync();
                SurpriseImage surpriseImage = await _context.SurpriseImages.Where(m => !m.SoftDeleted).FirstOrDefaultAsync();
                Surprise supriseText = await _context.SurpriseText.FirstOrDefaultAsync();
                List<Expert> experts = await _expertService.GetExpertsAsync();
                List<Blog> blogs = await _context.Blogs.Where(m => !m.SoftDeleted).ToListAsync();
                List<Instagram> instagrams = await _instagramService.GetInstagramAsync();

                HomeVM model = new()
                {
                    Sliders = sliders,
                    SliderInfo = slidersInfo,
                    Categories = categories,
                    Products = products,
                    SurpriseImage = surpriseImage,
                    SurpriseText = supriseText,
                    Experts = experts,
                    Blogs = blogs,
                    Instagrams = instagrams
                };
                return View(model);
            }

        }
    }
