using Microsoft.OpenApi.Models;
using TravelTipsAPI.Interfaces;
using TravelTipsAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Travel Tips API",
        Version = "v1",
        Description = "Uma API com dicas de viagens e links para Airbnbs em várias cidades do mundo 🌍",
        Contact = new OpenApiContact
        {
            Name = "Angelica Sales",
            Email = "angelicasalesantunes@outlook.com",
            Url = new Uri("https://github.com/angelsales4/TravelTipsAPI")
        }
    });
});

builder.Services.AddSingleton<ITravelTipRepository, TravelTipRepository>();

var app = builder.Build();

app.UseCors("AllowAll");

// Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Travel Tips API v1");
    c.RoutePrefix = "swagger";
});

// Pipeline
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
