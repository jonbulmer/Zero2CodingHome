using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Exam.Objective3_5
{
    class LoggingAndTracing
{
        //Listing 3-4 Using the debug Class
        public static void UsingTheDebugClass()
        {
            Debug.WriteLine("Stating the application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "i is greater than 0");
        }

        // Listing 3-46 Using the TraceSource class
        public static void UsingTheTraceSourceClass()
        {
            TraceSource traceSource = new TraceSource("MyTraceSource", SourceLevels.All);

            traceSource.TraceInformation("Tracing Application...");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });

            traceSource.Flush();
            traceSource.Close();
        }

        //Listing 3-47 Configuring TraceListener
        public static void ConfiguringTraceListener()
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);

            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);

            traceSource.TraceInformation("Trace output");

            traceSource.Flush();
            traceSource.Close();
        }
    }

    // Listing 3-49 Writing data to the event log

    public class MySample
    {
        public static void WritingDataToTheEventLog()
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }

            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log Event!");
        }
    }




}
