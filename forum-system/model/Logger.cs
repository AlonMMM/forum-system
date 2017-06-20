using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forum_system.model
{
    class Logger
    {
        private static Logger logger = null;

        private Logger() { }

        public static Logger getInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void logError(string error)
        {
            log(error, "\\errors.txt");
        }

        public void logAction(string action)
        {
            log(action, "\\actions.txt");
        }

        private void log(string log, string fileName)
        {
            string path = Directory.GetCurrentDirectory() + "\\log";
            using (StreamWriter file = new StreamWriter(path + fileName, true))
            {
                file.WriteLine("***" + DateTime.Now + " : " + log + "***");
            }
        }
    }
}
