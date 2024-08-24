using DDDSampleProject.Application;
using DDDSampleProject.Infrastructure;
using DDDSampleProject.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSharedServices();
builder.Services.AddApplicationConfiguration();
builder.Services.ConfigureInfraServices(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
