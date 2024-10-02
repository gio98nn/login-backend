using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços necessários, como o suporte a controladores
builder.Services.AddControllers();

// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder
            .AllowAnyOrigin()  // Permite qualquer origem
            .AllowAnyMethod()  // Permite qualquer método (GET, POST, PUT, DELETE, etc.)
            .AllowAnyHeader(); // Permite qualquer cabeçalho
    });
});

var app = builder.Build();

// Configura o pipeline de middleware da aplicação
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Habilita o CORS no pipeline
app.UseCors("AllowAllOrigins");

// Define o roteamento para os controladores
app.MapControllers();

app.Run();