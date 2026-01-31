using LoggingFrameWork_LLD.Enums;
using LoggingFrameWork_LLD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Configs
{
    public class LoggerConfig
    {
        public LogLevel MinimumLogLevel { get; set; }
        public List<ILogAppender> Appenders { get; } = new();
    }
}
