using LoggingFrameWork_LLD.Interfaces;
using LoggingFrameWork_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Appenders
{
    public class ConsoleAppender : ILogAppender
    {
        public void Append(LogMessage message)
        {
            Console.WriteLine(
                $"[{message.Timestamp:O}] [{message.Level}] {message.Message}"
            );
        }
    }
}
