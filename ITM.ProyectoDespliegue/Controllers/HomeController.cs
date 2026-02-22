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
            return Ok("Hello World desde la nueva funcionalidad");
        }
    }
}