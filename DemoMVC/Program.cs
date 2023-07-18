<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
=======
using DemoMVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
>>>>>>> 5b0931c58c22c6c6fe50b120244a1cc400eb9e00
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
<<<<<<< HEAD
if (!app.Environment.IsDevelopment())
=======
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
>>>>>>> 5b0931c58c22c6c6fe50b120244a1cc400eb9e00
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
<<<<<<< HEAD
=======
app.MapRazorPages();
>>>>>>> 5b0931c58c22c6c6fe50b120244a1cc400eb9e00

app.Run();
