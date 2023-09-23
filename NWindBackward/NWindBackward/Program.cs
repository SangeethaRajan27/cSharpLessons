using Microsoft.EntityFrameworkCore;
using NWindBackward.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddDbContext<NorthwindContext>(options=>options.UseSqlServer("name=NWindConnection"));
builder.Services.AddScoped<RepositoryEmployee>();
builder.Services.AddScoped<RepositoryOrders>();
builder.Services.AddScoped<RepositoryCustomer>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
