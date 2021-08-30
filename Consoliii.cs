using System;
using BetterLogging;

namespace LoggerPackage
{
    public static class Consoliii
    {
        public static void WriteLine(bool value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(char value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(char[] value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(decimal value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(double value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(float value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(int value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(long value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(object value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(string value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(uint value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(ulong value, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(value), colors);
        public static void WriteLine(string format, object arg0, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(format, arg0), colors);
        public static void WriteLine(string format, object[] args, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(format, args), colors);
        public static void WriteLine(char[] buffer, int index, int count, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(buffer, index, count), colors);
        public static void WriteLine(string format, object arg0, object arg1, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(format, arg0, arg1), colors);
        public static void WriteLine(string format, object arg0, object arg1, object arg2, ColorPair colors = null)
            => WrapWithColors(() => Console.WriteLine(format, arg0, arg1, arg2), colors);

        public static void Write(bool value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(char value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(char[] value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(decimal value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(double value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(float value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(int value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(long value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(object value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(string value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(uint value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(ulong value, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(value), colors);
        public static void Write(string format, object arg0, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(format, arg0), colors);
        public static void Write(string format, object[] args, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(format, args), colors);
        public static void Write(char[] buffer, int index, int count, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(buffer, index, count), colors);
        public static void Write(string format, object arg0, object arg1, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(format, arg0, arg1), colors);
        public static void Write(string format, object arg0, object arg1, object arg2, ColorPair colors = null)
            => WrapWithColors(() => Console.Write(format, arg0, arg1, arg2), colors);

        public static void Clear()
            => Console.Clear();

        public static void SetColors(ConsoleColor foreColor)
            => SetColors(new ColorPair(foreColor));
        public static void SetColors(ConsoleColor foreColor, ConsoleColor backColor)
            => SetColors(new ColorPair(foreColor, backColor));
        public static void SetColors(ColorPair colors)
        {
            Console.BackgroundColor = colors.BackColor;
            Console.ForegroundColor = colors.ForeColor;
        }

        public static void WrapWithColors<T1, T2, T3>(Action<T1, T2, T3> exec, T1 arg1, T2 arg2, T3 arg3, ColorPair colors = null)
        {
            var colorsBefore = new ColorPair(Console.ForegroundColor, Console.BackgroundColor);
            if (colors is not null) SetColors(colors);
            exec(arg1, arg2, arg3);
            SetColors(colorsBefore);
        }
        public static void WrapWithColors<T1, T2>(Action<T1, T2> exec, T1 arg1, T2 arg2, ColorPair colors = null)
        {
            var colorsBefore = new ColorPair(Console.ForegroundColor, Console.BackgroundColor);
            if (colors is not null) SetColors(colors);
            exec(arg1, arg2);
            SetColors(colorsBefore);
        }
        public static void WrapWithColors<T1>(Action<T1> exec, T1 arg1, ColorPair colors = null)
        {
            var colorsBefore = new ColorPair(Console.ForegroundColor, Console.BackgroundColor);
            if (colors is not null) SetColors(colors);
            exec(arg1);
            SetColors(colorsBefore);
        }
        public static void WrapWithColors(Action exec, ColorPair colors = null)
        {
            var colorsBefore = new ColorPair(Console.ForegroundColor, Console.BackgroundColor);
            if (colors is not null) SetColors(colors);
            exec();
            SetColors(colorsBefore);
        }
    }
}
