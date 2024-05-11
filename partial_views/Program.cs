using Microsoft.EntityFrameworkCore;
using partial_views.Data;
using partial_views.Services;
using partial_views.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoriyService, CategoryService>();
builder.Services.AddScoped<IExpertService, ExpertService>();
builder.Services.AddScoped<IInstagramService, InstagramService>();


builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

