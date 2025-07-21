using Microsoft.EntityFrameworkCore;
using OnlineStoreDouble.Data;
using OnlineStoreDouble.Data.Repositories;
using OnlineStoreDouble.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();
var connection = builder.Configuration.GetConnectionString("OnlineStoreConnectionString");
builder.Services.AddDbContext<OnlineStoreDBContext>(options =>
        options.UseNpgsql(connection));


builder.Services.AddScoped<IRepositoryProductCayegory, RepositoryProductCategory>();
builder.Services.AddScoped<IProduct, RepositoryProduct>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
