using Microsoft.EntityFrameworkCore;
using MoneyTrackAPI.Data;
using MoneyTrackAPI.Repositories;
using MoneyTrackAPI.Repositories.Implementations;
using MoneyTrackAPI.Services;
using MoneyTrackAPI.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Store Repository
builder.Services.AddDbContext<MoneyTrackDbContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("db"));
});
builder.Services.AddScoped<ITypeExpenseRepository, TypeExpenseRepository>();

// Service
builder.Services.AddScoped<ITypeExpenseService, TypeExpenseService>();

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
