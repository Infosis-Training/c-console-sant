using Microsoft.EntityFrameworkCore;
using MovieManagement.Database;
using System.Configuration;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DBContext connect to Database
//connect Sql Database here, add multiple if needs to connect multiple db.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(

    //@"Server=(localdb)\mssqllocaldb;Database=MovieManagement;Trusted_Connection=True;"
    
    builder.Configuration.GetConnectionString("DefaultConnection") //config from appsetting.json

));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

app.Run();
