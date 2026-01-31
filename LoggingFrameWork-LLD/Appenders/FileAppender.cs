using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingFrameWork_LLD.Interfaces;
using LoggingFrameWork_LLD.Models;
using System.IO;

namespace LoggingFrameWork_LLD.Appenders
{
    public class FileAppender : ILogAppender
    {
        private readonly string _filePath;
        private static readonly object _lock = new();

        public FileAppender(string filePath)
        {
            _filePath = filePath;
        }

        public void Append(LogMessage message)
        {
            lock (_lock)
            {
                File.AppendAllText(
                    _filePath,
                    $"[{message.Timestamp:O}] [{message.Level}] {message.Message}\n"
                );
            }
        }
    }

}
