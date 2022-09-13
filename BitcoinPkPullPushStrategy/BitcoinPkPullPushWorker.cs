using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BitcoinPkPullPushStrategy;

public class BitcoinPkPullPushWorker : BackgroundService
{
    private readonly ILogger<BitcoinPkPullPushWorker> _logger;

    public BitcoinPkPullPushWorker(
        ILogger<BitcoinPkPullPushWorker> logger)
    {
        this._logger = logger;
        
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        this._logger.LogInformation("Worker started at: {0}", DateTimeOffset.Now);

        return Task.CompletedTask;
    }
}