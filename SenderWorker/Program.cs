using SenderWorker;
using Serilog;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .UseSerilog(Shared.Logging.Extensions.ConfigureLogger("SenderWorker"))
    .Build();


await host.RunAsync();

