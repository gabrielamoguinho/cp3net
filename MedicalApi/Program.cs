using MedicalLib;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Servi�os
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Consultas M�dicas",
        Version = "v1"
    });
});

var app = builder.Build();

// Middleware Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Consultas M�dicas V1");
        c.RoutePrefix = string.Empty;
    });
}

app.MapControllers();

// C�digo de teste da lib (pode remover depois)
Console.WriteLine(new Paciente { Nome = "Gabi" }.ObterIdentificacao());

app.Run();
