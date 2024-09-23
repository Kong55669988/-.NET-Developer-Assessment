using Developer_Assessment.Models;
using Developer_Assessment.Models.Entity.Freelancers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddDbContext<CDNDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddDbContext<CDNDbContext>(options =>
//   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
//       sqlOptions =>
//       {
//           sqlOptions.EnableRetryOnFailure(
//               maxRetryCount: 5, // Number of retry attempts
//               maxRetryDelay: TimeSpan.FromSeconds(1), // Delay between retries
//               errorNumbersToAdd: null); // Optional: Add specific error numbers for retries (can be null)
//       })
//);
builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>)); 
builder.Services.AddScoped<FreelancerManager>();
 
builder.Services.AddControllersWithViews(); 
var app = builder.Build();
 
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
