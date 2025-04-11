#nullable enable
using Microsoft.Extensions.Logging;

// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

partial class StructuredLogging(ILogger logger)
{
    // static readonly Action<ILogger, int, string, Exception?> TraceException =
    //     LoggerMessage.Define<int, string>(
    //         LogLevel.Trace,
    //         new EventId(42, "Failed"),
    //         "Execution failed #{Id} \"{Name}\" {Undefined}");
    //
    // [LoggerMessage(
    //     "Work failed #{Id} \"{Name}\" {Undefined}",
    //     Level = LogLevel.Warning)]
    // partial void WarnException(int id, string name, Exception exception);
}
