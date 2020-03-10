﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace EnvelopesTask.Classes.Logging
{
    public static class Logger
    {
        #region

        private static ILog log = LogManager.GetLogger("LOGGER");

        #endregion

        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
