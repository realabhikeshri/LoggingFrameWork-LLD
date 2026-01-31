using LoggingFrameWork_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFrameWork_LLD.Interfaces
{
    public interface ILogAppender
    {
        void Append(LogMessage message);
    }
}
