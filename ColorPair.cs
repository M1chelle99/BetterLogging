using System;
using LoggerPackage;

namespace BetterLogging
{
    public class ColorPair
    {
        public ColorPair(ConsoleColor? foreColor = null, ConsoleColor? backColor = null)
        {
            ForeColor = foreColor ?? Console.ForegroundColor;
            BackColor = backColor ?? Console.BackgroundColor;
        }

        public ConsoleColor ForeColor { get; }
        public ConsoleColor BackColor { get; }
    }
}
