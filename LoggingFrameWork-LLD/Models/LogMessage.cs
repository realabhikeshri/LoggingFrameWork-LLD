using LoggingFrameWork_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Models
{
    public class LogMessage
    {
        public LogLevel Level { get; }
        public string Message { get; }
        public DateTime Timestamp { get; }

        public LogMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
            Timestamp = DateTime.UtcNow;
        }
    }
}
