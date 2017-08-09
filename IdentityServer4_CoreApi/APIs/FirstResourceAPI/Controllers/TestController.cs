using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstResourceAPI.Controllers
{
    [Route("test")]
    [Authorize]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "OK";
        }
    }
}