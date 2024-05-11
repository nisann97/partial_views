using System;
using partial_views.Models;

namespace partial_views.ViewModels
{
	public class HomeVM
	{
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public Surprise SurpriseText { get; set; }
        public SurpriseImage SurpriseImage { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Instagram> Instagrams { get; set; }
    }
}

