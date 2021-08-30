using System;
using System.Globalization;
using BetterLogging;

namespace LoggerPackage
{
    public class LoggerConfig
    {
        public bool UseUTC { get; set; }
        public string CustomFormat { get; set; }
        public bool IgnoreCasing { get; set; }
        public LoggerColors Colors { get; set; } = new();
        public IFormatProvider FormatProvider { get; set; } = CultureInfo.CurrentCulture;
    }
}
