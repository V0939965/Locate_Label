using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace Charles
{
    class MyLogger
    {
        Logger mLogger;
        private static MyLogger mMyLog;
        private MyLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "system.log" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            config.AddRule(LogLevel.Trace, LogLevel.Error, logconsole);
            config.AddRule(LogLevel.Trace, LogLevel.Error, logfile);
            NLog.LogManager.Configuration = config;
            mLogger = NLog.LogManager.GetCurrentClassLogger();
        }

        public void Info(string info)
        {
            mLogger.Info(info);
        }

        public void Error(string error)
        {
            mLogger.Error(error);
        }

        public static MyLogger GetInstance()
        {
            if (mMyLog == null)
                mMyLog = new MyLogger();
            return mMyLog;
        }
        public void Warning(string warning)
        {
            mLogger.Warn(warning);
        }
    }
}
