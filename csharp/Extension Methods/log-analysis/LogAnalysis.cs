using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string delimiter)
    {
        return message[(message.IndexOf(delimiter) + delimiter.Length)..];
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string initDelimiter, string finalDelimiter)
    {
        int startIndex = message.IndexOf(initDelimiter) + initDelimiter.Length;
        int endIndex = message.IndexOf(finalDelimiter, startIndex);
        return message[startIndex..endIndex].Trim();
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string message)
    {
        //return message[(message.IndexOf(": ") + message.Length)..].Trim();
        return message.SubstringAfter("]:").Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logMessage)
    {
        return SubstringBetween(logMessage, "[", "]");
    }
}