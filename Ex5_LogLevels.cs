using System;

static class LogLine {
    public static string Message(string logLine) {

        String[] msgArray = logLine.Split(":", 2);
        return msgArray[1].Trim();
    }

    public static string LogLevel(string logLine) {
        
        String[] errArray = logLine.Split("]", 2);
        return errArray[0].Replace("[", "").ToLower();
    }

    public static string Reformat(string logLine) {

        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
