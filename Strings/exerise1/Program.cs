static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');

        if (colonIndex == -1)
        {
            return string.Empty;
        }

        return logLine[(colonIndex + 2)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']');

        if (startIndex == -1 || endIndex == -1 || startIndex >= endIndex)
        {
            return string.Empty;
        }

        return logLine[startIndex..endIndex].ToLowerInvariant();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}

class Test
{
    static void Main()
    {

    }
}
