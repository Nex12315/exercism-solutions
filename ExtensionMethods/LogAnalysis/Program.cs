public static class LogAnalysis
{
    public static string SubstringAfter(this string logLine, string after)
    {
        int afterIndex = logLine.IndexOf(after);
        if (afterIndex == -1)
        {
            return string.Empty;
        }
        return logLine[(afterIndex + after.Length)..];
    }

    public static string SubstringBetween(this string logLine, string start, string end)
    {
        int startIndex = logLine.IndexOf(start);
        int endIndex = logLine.IndexOf(end);
        if (startIndex == -1 || endIndex == -1 || startIndex >= endIndex)
        {
            return string.Empty;
        }
        return logLine[(startIndex + start.Length)..endIndex];
    }

    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ");
    }

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}


class Program
{
    public static void Main()
    {
        var log = "I am the 2nd test";

        Console.WriteLine(log.SubstringAfter("2nd"));

        log = "FIND >>> SOMETHING <===< HERE";
        Console.WriteLine(log.SubstringBetween(">>> ", " <===<"));

        log = "[ERROR]: Missing ; on line 20.";
        Console.WriteLine(log.Message());

        log = "[ERROR]: Missing ; on line 20.";
        Console.WriteLine(log.LogLevel());
    }
}