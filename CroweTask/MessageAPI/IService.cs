using System;

namespace ServiveAPI
{
    public interface IService
    {       
        string GetInfo();
    }

    /* Services */
    public class ConsoleService : IService
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
    public class MobileService : IService
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
    public class WebApplicationService : IService
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
    public class WindowsApplicationService : IService
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}


