using System;
using System.Linq;
using BetterLogging;

namespace LoggerPackage
{
    public static class Logger
    {
        public static LoggerConfig Config { get; } = new();

        public static void Log(LogMessage message)
        {
            var timestamp = FormatProvider.GetTimestamp(message.Timestamp);
            Consoliii.Write(timestamp, Config.Colors.TimestampColor);
            Consoliii.Write(" ");
            Consoliii.Write("[", Config.Colors.BracketsColor);
            Consoliii.Write(message.Subject, GetSubjectColor(message));
            Consoliii.Write("]", Config.Colors.BracketsColor);
            Consoliii.Write(" ");
            int padLeft = timestamp.Length
                + " ".Length
                + "[".Length
                + message.Subject.Length
                + "]".Length
                + " ".Length;

            Consoliii.Write(message.Message
                .ToString()
                .Replace(
                    Environment.NewLine, 
                    Environment.NewLine 
                    + new string(' ', padLeft)), 
                GetMessageColor(message));
        }

        private static ColorPair GetSubjectColor(LogMessage message)
        {
            string matchingKey = message.Subject;
            if (Config.IgnoreCasing)
                matchingKey = Config.Colors.SubjectColors.Keys.FirstOrDefault(x => x.ToLower() == message.Subject.ToLower());
            if (Config.Colors.SubjectColors.TryGetValue(matchingKey, out var colorOverride))
                return colorOverride.SubjectColor;
            return Config.Colors.SubjectDefaultColor;
        }

        private static ColorPair GetMessageColor(LogMessage message)
        {
            string matchingKey = message.Subject;
            if (Config.IgnoreCasing)
                matchingKey = Config.Colors.SubjectColors.Keys.FirstOrDefault(x => x.ToLower() == message.Subject.ToLower());
            if (Config.Colors.SubjectColors.TryGetValue(matchingKey, out var colorOverride))
                return colorOverride.MessageColor;
            return Config.Colors.MessageDefaultColor;
        }
    }
}