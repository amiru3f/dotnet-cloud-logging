using ReceiverWorker;
using Serilog;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .UseSerilog(Shared.Logging.Extensions.ConfigureLogger("ReceiverWorker"))
    .Build();


await host.RunAsync();