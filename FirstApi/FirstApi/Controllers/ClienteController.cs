using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "Minha primeira API .NET CORE no Framework 6.0";
        }
    }
}