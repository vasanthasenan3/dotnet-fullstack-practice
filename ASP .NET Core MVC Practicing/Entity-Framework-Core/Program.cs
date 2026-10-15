using Microsoft.EntityFrameworkCore;
using ShopingApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connection = builder.Configuration.GetConnectionString("Jscon");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(name: "default",
    pattern: "{Controller=Home}/{Action=AboutUs}/{ID?}");

app.Run();
