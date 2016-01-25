namespace SolidLogger.Appenders
{
    using System;

    using SolidLogger.Formatters;
    using SolidLogger.Interfaces;

    public abstract class Appender : IAppender
    {
        private IFormatter formatter;

        protected Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter
        {
            get
            {
                return this.formatter;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Format cannot be null");
                }

                this.formatter = value;
            }
        }

        public abstract void Append(string message, ReportLevel level, DateTime date);
    }
}
