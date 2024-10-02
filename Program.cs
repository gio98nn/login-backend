using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os necess�rios, como o suporte a controladores
builder.Services.AddControllers();

// Configura��o do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder
            .AllowAnyOrigin()  // Permite qualquer origem
            .AllowAnyMethod()  // Permite qualquer m�todo (GET, POST, PUT, DELETE, etc.)
            .AllowAnyHeader(); // Permite qualquer cabe�alho
    });
});

var app = builder.Build();

// Configura o pipeline de middleware da aplica��o
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Habilita o CORS no pipeline
app.UseCors("AllowAllOrigins");

// Define o roteamento para os controladores
app.MapControllers();

app.Run();