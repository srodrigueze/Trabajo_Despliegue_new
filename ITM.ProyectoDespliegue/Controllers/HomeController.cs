using Microsoft.AspNetCore.Mvc;

namespace ITM.ProyectoDespliegue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Mensaje Ya quiero terminar);
        }
    }
}