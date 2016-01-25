namespace SolidLogger.Formatters
{
    using System;

    using SolidLogger.Interfaces;

    public class SimpleFormatter : IFormatter
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            string result = string.Format("{0} - {1} - {2}", date, level, msg);
            return result;
        }
    }
}
