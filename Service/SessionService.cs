using DistractionTracker.Interfaces;
using DistractionTracker.Repository;

namespace DistractionTracker.Service
{
    public class SessionService: ISessionService
    {
        private readonly SessionRepository _repository;
        public SessionService(SessionRepository repository) 
        {
            _repository = repository;
        }
        
        public string PostSession()
        {
            string result = string.Empty;
            Guid repo = _repository.CreateSession();
            return result;
        }
    }
}
