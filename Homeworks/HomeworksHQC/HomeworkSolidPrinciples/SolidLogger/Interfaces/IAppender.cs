namespace SolidLogger.Interfaces
{
    using System;

    using SolidLogger.Formatters;

    public interface IAppender
    {
        IFormatter Formatter { get; set; }

        void Append(string message, ReportLevel level, DateTime date);
    }
}
