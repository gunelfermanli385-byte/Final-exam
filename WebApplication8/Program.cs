using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using WebApplication8.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DewiDbContext>(options =>
{
    options.UseSqlServer("Server=.;Database=DewiDb;Trusted_Connection=True;TrustServerCertificate=True");
});
    
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}"
    
    );

app.Run();
