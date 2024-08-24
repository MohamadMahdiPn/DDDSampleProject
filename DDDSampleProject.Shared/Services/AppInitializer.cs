using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace DDDSampleProject.Shared.Services;

public sealed class AppInitializer : IHostedService
{
    private readonly IServiceProvider _serviceProvider;
    public AppInitializer(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var dbContextTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a=>a.GetTypes()
            .Where(x=> typeof(DbContext).IsAssignableFrom(x) && !x.IsInterface && x!= typeof(DbContext)));
        using var scope = _serviceProvider.CreateScope();
        foreach (var dbType in dbContextTypes)
        {
            var dbContext = scope.ServiceProvider.GetRequiredService(dbType) as DbContext;
            if (dbContext is null)
                continue;
           await dbContext.Database.EnsureCreatedAsync(cancellationToken);
                
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
       await Task.CompletedTask;
    }
}
