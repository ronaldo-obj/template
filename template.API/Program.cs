using DataTransfer.Weather.Aplicacao.Servicos;
using DataTransfer.Weather.Aplicacao.Profiles;
using Dominio.Weather.Servicos;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(WeatherForecastProfile).GetTypeInfo().Assembly);
builder.Services.Scan(scan => scan
    .FromAssemblyOf<WeatherAppServico>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());
builder.Services.Scan(scan => scan
    .FromAssemblyOf<WeatherServico>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());
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
