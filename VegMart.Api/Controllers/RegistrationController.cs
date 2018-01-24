using Microsoft.AspNetCore.Mvc;
using VegMart.Api.Services;
using VegMart.Data;

namespace VegMart.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Registration")]
    public class RegistrationController : Controller
    {
        private IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost]
        public ActionResult Create([FromBody]UnitRegistrations registration)
        {
            var result =  _registrationService.Register(registration);
            return Ok();
        }
    }
}