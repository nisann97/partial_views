using System;
using partial_views.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace partial_views.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {

            var sliders = GetSliders();
            return View(sliders);
        }

        private List<Slider> GetSliders()
        {
            return new List<Slider>
            {
                new Slider()
                {
                    Id = 1,
                    Title = "Tofig",
                    Description = "Heci Tofig"
                },
                   new Slider()
                {
                    Id = 2,
                    Title = "Omer",
                    Description = "Omer Xeyyam"
                },
                     new Slider()
                {
                    Id = 3,
                    Title = "Rufet",
                    Description = "Rufet Nasosnu"
                }

            };

                
        } 
    }
}

