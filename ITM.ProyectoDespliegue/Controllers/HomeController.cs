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
             Ok("Nuevo mensaje desde la corrección.")
        }
    }
}