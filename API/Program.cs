using DTO.ModelsDTO;
using AutoMapper;
using DTO;
using Microsoft.EntityFrameworkCore;
using BL;
using DAL;
using DAL.Entities;


var builder = WebApplication.CreateBuilder(args);
//מודיעה לפרוגרם שהוא הולך להשתמש בכמה תלויות 
builder.Services.AddScoped<IUsersBL, UsersBL>();
builder.Services.AddScoped<IUsersDAL, UsersDAL>();
builder.Services.AddScoped<IProductsBL, ProductsBL>();
builder.Services.AddScoped<IProductsDAL, ProductsDAL>();
builder.Services.AddScoped<IOrdersBL, OrdersBL>();
builder.Services.AddScoped<IOrdersDAL, OrdersDAL>();

// Add services to the container.
builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer("Server=localhost;Database=Shop;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddCors();
builder.Services.AddAutoMapper(typeof(AutoMapping).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
