using TravelTipsAPI.Interfaces;
using TravelTipsAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os controladores (Controllers/)
builder.Services.AddControllers();

// Registra o repositório como um serviço (injeção de dependência)
builder.Services.AddSingleton<ITravelTipRepository, TravelTipRepository>();

// Adiciona suporte ao Swagger (documentação automática)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do ambiente de desenvolvimento
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redireciona HTTP → HTTPS
app.UseHttpsRedirection();

// Autorizações (não estamos usando por enquanto, mas é padrão)
app.UseAuthorization();

// Mapeia os controllers (rota /api/...)
app.MapControllers();

// Inicia o app
app.Run();
