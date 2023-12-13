using System.Runtime.CompilerServices;

namespace CSharp10;

file static class InterpolatedStringHandler
{
    public static void Start()
    {
        var logger = new Logger();
        // TODO: Goto definition on interpolation holes
        logger.LogDebug($"This is an {new object()} string handled by {nameof(DebugLoggerStringHandler)}");

        // TODO: should convert
        logger.LogDebug("This is a {0} string that can be converted to {1}", "formatted",
            nameof(DebugLoggerStringHandler));
    }

    [InterpolatedStringHandler]
    private ref struct DebugLoggerStringHandler
    {
        private DefaultInterpolatedStringHandler _builder;

        public DebugLoggerStringHandler(
            int literalLength,
            int formattedCount,
            Logger logger,
            out bool handlerIsValid)
        {
            handlerIsValid = logger.Level <= LogLevel.Debug;
            _builder = new(literalLength, formattedCount);
        }

        // Find usages of below Append methods

        public void AppendLiteral(string value)
            => _builder.AppendLiteral(value);

        public void AppendFormatted<T>(T t, int alignment = 0, string? format = null)
            => _builder.AppendFormatted(t, alignment, format);

        public string ToStringAndClear()
            => _builder.ToStringAndClear();
    }

    private class Logger
    {
        public LogLevel Level { get; set; }

        public void Log(LogLevel level, string message)
        {
            Console.WriteLine($"{level}: {message}");
        }

        public void LogDebug(
            // Suggests parameter name (empty for 'this')
            [InterpolatedStringHandlerArgument("")]
            ref DebugLoggerStringHandler handler)
        {
            if (Level <= LogLevel.Debug)
                Log(LogLevel.Debug, handler.ToStringAndClear());
        }

        [StringFormatMethod("format")]
        public void LogDebug(
            string format,
            params object[] args)
        {
            if (Level <= LogLevel.Debug)
                Log(LogLevel.Debug, string.Format(format, args));
        }
    }

    private enum LogLevel
    {
        Trace,
        Debug,
        Info,
        Warn,
        Error
    }
}