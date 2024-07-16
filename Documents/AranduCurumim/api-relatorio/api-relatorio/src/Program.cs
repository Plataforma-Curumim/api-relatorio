using api_relatorio.Infra.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGlobalExtensions(builder.Configuration);

var app = builder.Build();
app.UseGlobalExtensions();
app.Run();