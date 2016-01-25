namespace ConsoleApp
{
    using System.Collections.Generic;
    using SolidLogger;
    using SolidLogger.Appenders;
    using SolidLogger.Formatters;
    using SolidLogger.Interfaces;

    internal class AppMain
    {
        public static void Main()
        {
            IFormatter formatter = new SimpleFormatter();
            IAppender appender = new ConsoleAppender(formatter);
            ILogger logger = new Logger(appender);

            IList<string> users = new List<string>();
            users.Add("Pesho");
            users.Add("Gosho");
            users.Add("Stamat");
            users.Add("Bate Goiko");
            users.Add("Pablo Escobar");
            users.Add("Osvaldo Rios");

            IList<string> ignoredUsers = new List<string>();

            foreach (var user in users)
            {
                if ((string)user == "Stamat")
                {
                    ignoredUsers.Add(user);
                }
                else
                {
                    logger.Info(string.Format("User {0} successfully registered", user));
                }
            }

            foreach (var ignUser in ignoredUsers)
            {
                logger.Error(string.Format("Error for {0} registration", ignUser));
            }
        }
    }
}
