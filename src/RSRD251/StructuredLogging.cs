#nullable enable
using Microsoft.Extensions.Logging;

namespace RSRD251;

file class StructuredLogging
{
    private static readonly Action<ILogger, int, string, Exception?> LogException =
        LoggerMessage.Define<int, string>(
            LogLevel.Trace,
            new EventId(42, "Failed"),
            "Execution failed #{Id} \"{Name}\"");
}
