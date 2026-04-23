using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Drkb.Logger.Serilog;

public static class SerilogHostBuilderExtensions
{
    public static IHostBuilder UseDrkbSerilog(
        this IHostBuilder hostBuilder,
        IConfiguration configuration,
        string applicationName)
    {
        return hostBuilder.UseSerilog((context, services, loggerConfiguration) =>
        {
            loggerConfiguration
                .ReadFrom.Configuration(configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Application", applicationName);
        });
    }
}