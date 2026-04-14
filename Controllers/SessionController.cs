using DistractionTracker.Service;
using Microsoft.AspNetCore.Mvc;

namespace DistractionTracker.Controllers
{
    [ApiController]
    public class SessionController: ControllerBase
    {
        private SessionService _service;
        private readonly ILogger _logger;
        public SessionController(ILogger logger, SessionService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public string PostSession()
        {
            string result = "";
            this._service.PostSession();
            return result;
        }

    }
}
