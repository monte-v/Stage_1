using solid_5_DIP;

class Program
{
    static void Main(string[] args)
    {
        // Использование ConsoleLogger
        ILogger consoleLogger = new ConsoleLogger();
        UserManager userManagerWithConsoleLogger = new UserManager(consoleLogger);
        userManagerWithConsoleLogger.CreateUser("JohnDoe");

        // Использование FileLogger
        ILogger fileLogger = new FileLogger();
        UserManager userManagerWithFileLogger = new UserManager(fileLogger);
        userManagerWithFileLogger.CreateUser("JaneDoe");
    }
}
