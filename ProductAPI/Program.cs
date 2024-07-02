using Microsoft.EntityFrameworkCore;
using ProductAPI.ApplicationCore.Interfaces.Repository;
using ProductAPI.ApplicationCore.Interfaces.Service;
using ProductAPI.Infrastructure.Data;
using ProductAPI.Infrastructure.Repository;
using ProductAPI.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<ProductDbContext>(options => {

    options.UseSqlServer(builder.Configuration.GetConnectionString("EShopDB"));
});

builder.Services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();


builder.Services.AddScoped<ICategoryServiceAsync,CategoryServiceAsync>();
builder.Services.AddScoped<IProductServiceAsync, ProductServiceAsync>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
