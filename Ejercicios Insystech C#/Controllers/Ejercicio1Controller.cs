using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio1Controller : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ProbarConectividad()
        {
            string mensaje = "La conexión ha sido establecida con éxito";
            return Ok(new { msg = mensaje });
        }
    }
}
