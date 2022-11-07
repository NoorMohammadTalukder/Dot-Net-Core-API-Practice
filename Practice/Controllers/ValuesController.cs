using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // [Route("GetFirstName")]
        [HttpGet]
        public string GetName()
        {
            return "Mack";
        }
        
       // m [Route("GetFullName")]
        [HttpGet]
        public string GetFullName()
        {
            return "Mack Jenon";
        }
    }
}
