using WriteMode;
using ServiveAPI;
using System.Configuration;
namespace HelloWorld
{
    public class Program
    {
        private static OutputWriter outputWriter;
        public static void Main(string[] args)
        {
            outputWriter = OutputWriter.GetOutputWriter(ConfigurationManager.AppSettings["WriteMode"]);    //The program has 1 current business requirement a write Hello World to the console/ screen.
            outputWriter.Write("Hello World");          // The program should support future enhancements for writing to a database, console application, etc.        
        }
    }
    public enum ServiceType
    {
        MobileApplication,
        WebApplication,
        ConsoleApplication,
        WindowsApplication
    }
    public class ProviderFinder
    {
        public IService LocateMsgService(ServiceType serviceType)
        {
            switch (serviceType)
            {
                case ServiceType.MobileApplication:
                    return new MobileService();

                case ServiceType.WebApplication:
                    return new WebApplicationService();

                case ServiceType.ConsoleApplication:
                    return new ConsoleService();

                case ServiceType.WindowsApplication:
                    return new WindowsApplicationService();

                default:
                    return new ConsoleService();
            }
        }
    }


}

