using Microsoft.EntityFrameworkCore;
using PartialViewDemo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
//assign the connection string to ApplicationDbContext class for CRUD
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(connectionString));


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
