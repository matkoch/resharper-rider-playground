// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file static class NameofEnumReference
{
    static void Trace(
        this ILogger logger, string message)
    {
        logger.Log($"{LogLevel.Trace.ToString()}: {message}");
        logger.Log($"{LogLevel.Debug.ToString()}: {message}");
        logger.Log($"{LogLevel.Warning.ToString()}: {message}");
    }

    interface ILogger
    {
        void Log(string message);
    }

    enum LogLevel
    {
        Trace,
        Debug,
        Information,
        Warning,
        Error,
        Fatal
    }
}
