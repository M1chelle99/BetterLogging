using System;
using LoggerPackage;

namespace BetterLogging
{
    public class ColorOverride
    {
        public ColorOverride(ColorPair subjectColor = null, ColorPair messageColor = null)
        {
            SubjectColor = subjectColor ?? new(ConsoleColor.White, ConsoleColor.Black);
            MessageColor = messageColor ?? new(ConsoleColor.White, ConsoleColor.Black);
        }

        public ColorPair SubjectColor { get; set; }
        public ColorPair MessageColor { get; set; }
    }
}
