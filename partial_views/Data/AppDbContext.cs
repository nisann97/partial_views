using System;
using partial_views.Models;
using Microsoft.EntityFrameworkCore;
namespace partial_views.Data
    
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<SurpriseImage> SurpriseImages { get; set; }
        public DbSet<Surprise> SurpriseText { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<SliderInfo>()
            .HasData(
            new SliderInfo
            {
                Id = 1,
                Title = "<h1>Send<span>flowers</span>like</h1><h1>you mean it </h1>",

                Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                Signature = "h2-sign-img.png"


            }
            );

            modelBuilder.Entity<Slider>()
           .HasData(
           new Slider
           {
               Id = 1,
               Name = "h3-slider-background.jpg",

           },
             new Slider
             {
                 Id = 2,
                 Name = "h3-slider-background-2.jpg",

             },

              new Slider
              {
                  Id = 3,
                  Name = "h3-slider-background-3.jpg",

              });

            modelBuilder.Entity<Category>()
           .HasData(
           new Category
           {
               Id = 1,
               Name = "POPULAR",
           },

           new Category
           {
               Id = 2,
               Name = "WINTER",

           },
             new Category
             {
                 Id = 3,
                 Name = "VARIOUS",

             },
               new Category
               {
                   Id = 4,
                   Name = "EXOTIC",

               },
                  new Category
                  {
                      Id = 5,
                      Name = "GREENS",

                  },
                     new Category
                     {
                         Id = 6,
                         Name = "CACTUSES",

                     }
           );

            modelBuilder.Entity<Product>()
         .HasData(


         new Product
         {
             Id = 1,
             Name = "Product1",
             CategoryId = 1,
             Price = 259M,
             Description = "Desc1"

         },
           new Product
           {
               Id = 2,
               Name = "Product2",
               Description = "desc2",
               CategoryId = 2,
               Price = 259M

           },
               new Product
               {
                   Id = 3,
                   Name = "Product3",
                   Description = "desc3",
                   CategoryId = 3,
                   Price = 259M

               },
                 new Product
                 {
                     Id = 4,
                     Name = "Product4",
                     Description = "desc4",
                     CategoryId = 4,
                     Price = 259M

                 },
                    new Product
                    {
                        Id = 5,
                        Name = "Product5",
                        Description = "desc5",
                        CategoryId = 5,
                        Price = 259M

                    },
                       new Product
                       {
                           Id = 6,
                           Name = "Product6",
                           Description = "desc6",
                           CategoryId = 6,
                           Price = 259M

                       },
                          new Product
                          {
                              Id = 7,
                              Name = "Product7",
                              Description = "desc7",
                              CategoryId = 3,
                              Price = 259M

                          },
                             new Product
                             {
                                 Id = 8,
                                 Name = "Product8",
                                 Description = "desc8",
                                 CategoryId = 2,
                                 Price = 259M

                             }
         );

            modelBuilder.Entity<ProductImage>()
    .HasData(
    new ProductImage
    {
        Id = 1,
        Name = "shop-14-img.jpg",
        ProductId = 1


    },

        new ProductImage
        {
            Id = 2,
            Name = "shop-13-img.jpg",
            ProductId = 2


        },
            new ProductImage
            {
                Id = 3,
                Name = "shop-12-img.jpg",
                ProductId = 3


            },
                new ProductImage
                {
                    Id = 4,
                    Name = "shop-11-img.jpg",
                    ProductId = 4


                },
                    new ProductImage
                    {
                        Id = 5,
                        Name = "shop-10-img.jpg",
                        ProductId = 5


                    },
                      new ProductImage
                      {
                          Id = 6,
                          Name = "shop-9-img.jpg",
                          ProductId = 6


                      },
                        new ProductImage
                        {
                            Id = 7,
                            Name = "shop-8-img.jpg",
                            ProductId = 7


                        },
                          new ProductImage
                          {
                              Id = 8,
                              Name = "shop-7-img.jpg",
                              ProductId = 8


                          });

            modelBuilder.Entity<Surprise>()
    .HasData(
    new Surprise
    {
        Id = 1,
        Title = "<h1>Suprise Your<span>Valentine!</span> Let us arrange a smile.</h1>",
        Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion..."

    });

            modelBuilder.Entity<SurpriseImage>()
.HasData(
new SurpriseImage
{
    Id = 1,
    Name = "h3-video-img.jpg"
});
            modelBuilder.Entity<Expert>()
.HasData(
new Expert
{
    Id = 1,
    Name = "CRYSTAL BROOKS",
    Profession = "Florist",
    Image = "h3-team-img-1.png"
},

new Expert
{
    Id = 2,
    Name = "SHIRLEY HARRIS",
    Profession = "Manager",
    Image = "h3-team-img-2.png"
},

new Expert
{
    Id = 3,
    Name = "BEVERLY CLARK",
    Profession = "Florist",
    Image = "h3-team-img-3.png"
},
new Expert
{
    Id = 4,
    Name = "AMANDA WATKINS",
    Profession = "Florist",
    Image = "h3-team-img-4.png"
}

);
            modelBuilder.Entity<Blog>().HasData(
new Blog
{
    Id = 1,
    Title = "Flower Power",
    Description = "Blog1",
    Image = "blog-feature-img-1.jpg",
    Date = DateTime.Now
},
new Blog
{
    Id = 2,
    Title = "Local Florists",
    Description = "Blog2",
    Image = "blog-feature-img-3.jpg",
    Date = DateTime.Now
},
new Blog
{
    Id = 3,
    Title = "Flower Beauty",
    Description = "Blog3",
    Image = "blog-feature-img-4.jpg",
    Date = DateTime.Now
});

        }


    }

}

