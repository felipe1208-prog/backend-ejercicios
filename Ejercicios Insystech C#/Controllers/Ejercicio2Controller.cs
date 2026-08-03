using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio2Controller : ControllerBase
    {
        [HttpPost("{sueldo}")]
        public async Task<IActionResult> CalculoSueldo([FromQuery] decimal? sueldo)
        {
            if (sueldo == null || sueldo <= 0)
            {
                return BadRequest(new { MensajeError400 = "Introduzca un sueldo válido" });
            }

            var sueldoLuegoImpuestos = sueldo - (sueldo * 0.055m);

            return Ok(sueldoLuegoImpuestos);
        }
    }
}
