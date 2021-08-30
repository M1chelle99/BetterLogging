using System;
using System.Collections.Generic;
using BetterLogging;

namespace LoggerPackage
{
    public class LoggerColors
    {
        public ColorPair TimestampColor { get; set; } = new(ConsoleColor.Cyan, ConsoleColor.Black);
        public ColorPair BracketsColor { get; set; } = new(ConsoleColor.White, ConsoleColor.Black);
        public ColorPair SubjectDefaultColor { get; set; } = new(ConsoleColor.White, ConsoleColor.Black);
        public ColorPair MessageDefaultColor { get; set; } = new(ConsoleColor.White, ConsoleColor.Black);
        public Dictionary<string, ColorOverride> SubjectColors { get; } = new()
        {
            ["Fatal"] = new(new(ConsoleColor.White, ConsoleColor.DarkRed), new(ConsoleColor.DarkRed)),
            ["Error"] = new(new(ConsoleColor.White, ConsoleColor.Red), new(ConsoleColor.Red)),
            ["Warning"] = new(new(ConsoleColor.White, ConsoleColor.DarkYellow), new(ConsoleColor.DarkYellow)),
            ["Info"] = new(new(ConsoleColor.White, ConsoleColor.DarkBlue), new(ConsoleColor.DarkBlue)),
            ["Message"] = new(new(ConsoleColor.White, ConsoleColor.Black), new(ConsoleColor.White)),
            ["Trace"] = new(new(ConsoleColor.White, ConsoleColor.DarkGray), new(ConsoleColor.Gray))
        };
    }
}
