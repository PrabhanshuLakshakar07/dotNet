using Microsoft.EntityFrameworkCore;
using MyEcommerceWEB_MVC.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Controllers and Views Services add karein
builder.Services.AddControllersWithViews();

// 2. Connection String configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 3. HTTP request pipeline configure karein
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4. Route Map karein (Taaki Home aur Product controller chal sakein)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// 5. Application ko running state me rakhne ke liye
app.Run();