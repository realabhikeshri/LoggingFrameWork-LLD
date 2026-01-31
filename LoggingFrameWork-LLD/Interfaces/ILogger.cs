using LoggingFrameWork_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Interfaces
{
    public interface ILogger
    {
        void Log(LogLevel level, string message);
    }
}
