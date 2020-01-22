using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SecurityLab1_Starter.Models
{
    public class LogUtil
    {

        public void LogToFile()
        {

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