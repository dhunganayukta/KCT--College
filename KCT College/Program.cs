using KCT_College.Data;
using KCT_College.Interface;
using KCT_College.Repositories;
using KCT_College.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICollegeService, CollegeService>();

// ✅ Correctly configure DbContext with connection string
builder.Services.AddDbContext<ApplicationdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=College}/{action=Index}/{id?}");

app.Run();
