﻿#region Usings

using System;
using System.Configuration;

#endregion

namespace Shared.Logging
{
    public class LoggingConfig : ILoggingConfig
    {
        public LogLvl LogLevel => (LogLvl) Enum.Parse(typeof(LogLvl),
                                                      ConfigurationManager.AppSettings["LogLevel"],
                                                      true);

        public string NlogConfigFileName => ConfigurationManager.AppSettings["NlogConfigFileName"];
    }
}