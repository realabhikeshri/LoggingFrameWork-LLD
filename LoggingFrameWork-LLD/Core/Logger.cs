using LoggingFrameWork_LLD.Configs;
using LoggingFrameWork_LLD.Enums;
using LoggingFrameWork_LLD.Interfaces;
using LoggingFrameWork_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Core
{
    public class Logger : ILogger
    {
        private readonly LoggerConfig _config;

        public Logger(LoggerConfig config)
        {
            _config = config;
        }

        public void Log(LogLevel level, string message)
        {
            if (level < _config.MinimumLogLevel)
                return;

            LogMessage logMessage = new(level, message);

            foreach (var appender in _config.Appenders)
            {
                appender.Append(logMessage);
            }
        }
    }

}
