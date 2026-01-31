using LoggingFrameWork_LLD.Appenders;
using LoggingFrameWork_LLD.Configs;
using LoggingFrameWork_LLD.Core;
using LoggingFrameWork_LLD.Enums;
using LoggingFrameWork_LLD.Interfaces;

public class Program
{
    public static void Main()
    {
        LoggerConfig config = new()
        {
            MinimumLogLevel = LogLevel.INFO
        };

        config.Appenders.Add(new ConsoleAppender());
        config.Appenders.Add(new FileAppender("application.log"));

        ILogger logger = new Logger(config);

        logger.Log(LogLevel.DEBUG, "This will not be logged");
        logger.Log(LogLevel.INFO, "Application started");
        logger.Log(LogLevel.ERROR, "Unhandled exception occurred");
    }
}
