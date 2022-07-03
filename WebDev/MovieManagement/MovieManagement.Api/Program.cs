using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieManagement.Api.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieManagementApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieManagementApiContext") ?? throw new InvalidOperationException("Connection string 'MovieManagementApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
