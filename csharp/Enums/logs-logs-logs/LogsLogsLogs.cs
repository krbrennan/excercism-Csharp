// TODO: define the 'LogLevel' enum
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

public enum LogLevel
{
    //TRC,
    //DBG,
    //INF,
    //WRN,
    //ERR,
    //FTL
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        // capture the log type
        int fIndex = logLine.IndexOf("[")+1;
        int lIndex = logLine.IndexOf("]")-1;
        string logType = logLine.Substring(fIndex, lIndex);
        //string log = getSubstring(logLine, "[", "]");
        Console.WriteLine(logType);
        switch (logType)
        {
            case "TRC":
                return LogLevel.Trace;
            case "DBG":
                return LogLevel.Debug;
            case "INF":
                return LogLevel.Info;
            case "WRN":
                return LogLevel.Warning;
            case "ERR":
                return LogLevel.Error;
            case "FTL":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        }
    }


    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }


    //public static string getSubstring(string, first, last)
    //{

    //}
}
