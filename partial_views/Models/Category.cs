using System;
namespace partial_views.Models
{
	public class Category : BaseEntity
	{
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

