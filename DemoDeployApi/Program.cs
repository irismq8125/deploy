using DemoDeployApi.Models.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QuanLySinhVienContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddMvcCore();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.DefaultModelsExpandDepth(-1));
}

app.UseSwagger();
app.UseSwaggerUI(c => c.DefaultModelsExpandDepth(-1));

app.UseAuthorization();

app.MapControllers();

app.Run();
