using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string trimmed = logLine.Trim();
        int startIndex = logLine.IndexOf(":") + 1;
        string unTrimmedMessage = trimmed.Substring(startIndex);
        string trimmedMessage = unTrimmedMessage.Trim();
        return trimmedMessage;
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']') - 1;
        string error = logLine.Substring(startIndex, endIndex).ToLower();
        return error;
    }

    public static string Reformat(string logLine)
    {
        string operation = Message(logLine);
        string type = LogLevel(logLine);
        return $"{operation} ({type})";
    }
}
