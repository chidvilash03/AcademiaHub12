using AcademiaHub.Models;
using AcademiaHub.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AcademiaHubContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AcademiaHubContext") ?? throw new InvalidOperationException("Connection string not found.")));


builder.Services.AddScoped<IAcademiaHubRepository, AcademiaHubRepository>();


// Add services for controllers
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
