using System;
using LoggerPackage;

namespace BetterLogging
{
    internal static class FormatProvider
    {
        public static string GetTimestamp(DateTime? dateTime = null)
        {
            if (!string.IsNullOrWhiteSpace(Logger.Config.CustomFormat))
                if (dateTime is not null)
                    return dateTime.Value.ToString(Logger.Config.CustomFormat);
                else
                {
                    if (Logger.Config.UseUTC)
                        return DateTime.UtcNow.ToString(Logger.Config.CustomFormat);
                    else
                        return DateTime.Now.ToString(Logger.Config.CustomFormat);
                }
            else if (Logger.Config.FormatProvider is not null)
                if (dateTime is not null)
                    return dateTime.Value.ToString(Logger.Config.FormatProvider);
                else
                {
                    if (Logger.Config.UseUTC)
                        return DateTime.UtcNow.ToString(Logger.Config.FormatProvider);
                    else
                        return DateTime.Now.ToString(Logger.Config.FormatProvider);
                }
            else
                throw new NullReferenceException("Cannot read FormatProvider of null. Please provide a FormatProvider or a Custom Format in the Logger Config.");
        }
    }
}
