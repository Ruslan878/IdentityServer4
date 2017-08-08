using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiIdSrv4withRSA
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