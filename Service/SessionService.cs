using DistractionTracker.Interfaces;

namespace DistractionTracker.Service
{
    public class SessionService: ISessionSevice
    {
        private ILogger _logger;
        public SessionService(ILogger logger) 
        {
            _logger = logger;
        }
        
        public string PostSession()
        {
            string result = string.Empty;
            try
            {

            }
            return result;
        }
    }
}
