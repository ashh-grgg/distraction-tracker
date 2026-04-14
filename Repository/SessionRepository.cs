using DistractionTracker.Interfaces;

namespace DistractionTracker.Repository
{
    public class SessionRepository: ISessionRepository
    {
        public SessionRepository() { }
        public Guid CreateSession()
        {

            return Guid.NewGuid();
        }
    }
}
