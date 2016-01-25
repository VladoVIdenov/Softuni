namespace SolidLogger.Interfaces
{
    using System;
    using SolidLogger.Formatters;

    public interface IFormatter
    {
        string Format(string msg, ReportLevel level, DateTime date);
    }
}
