using Microsoft.Extensions.Logging;
#pragma warning disable IDE0051

// ReSharper disable UnusedType.Global

namespace RSRD252;

public partial class LoggerMessage(ILogger<LoggerMessage> logger)
{
    private void M(string arg)
    {
        logger.LogInformation("{Arg} was passed", arg);
    }
}
