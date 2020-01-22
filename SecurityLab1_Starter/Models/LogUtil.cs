using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace SecurityLab1_Starter.Models
{
    public class LogUtil
    {

        public void LogToFile(String text)
        {
            using(var writer = new StreamWriter("ErrorLog.txt"))
            {
                var currentDate = new DateTime();
                writer.WriteLine("[{0}] {1}", currentDate.ToString(), text);
            }
        }

        public void LogToEventView(EventLogEntryType type, String text)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(text, type, 101, 1);
            }
        }

    }
}