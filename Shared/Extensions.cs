using System.Net;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Network;

namespace Shared.Logging;

public static class Extensions
{
    public static Action<HostBuilderContext, LoggerConfiguration> ConfigureLogger(string applicationName) => (hostingContext, loggerConfiguration) =>
    {
        Serilog.Debugging.SelfLog.Enable(Console.Error);
        loggerConfiguration.MinimumLevel.Information();
        loggerConfiguration.Enrich.FromLogContext();
        loggerConfiguration.Enrich.WithProperty("ApplicationName", applicationName);

        loggerConfiguration.MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning);
        loggerConfiguration.MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Warning);
        loggerConfiguration.MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning);
        loggerConfiguration.MinimumLevel.Override("Microsoft.EntityFrameworkCore.Database.Command", LogEventLevel.Warning);

        loggerConfiguration
        .MinimumLevel.Verbose().WriteTo.UDPSink(IPAddress.Parse("127.0.0.1"), 24224);

    };
}