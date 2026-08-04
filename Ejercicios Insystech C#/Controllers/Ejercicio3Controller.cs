using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio3Controller : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CalculoSueldo([FromQuery] decimal? sueldo)
        {
            if (sueldo == null || sueldo <= 0)
            {
                return BadRequest(new { MensajeError400 = "Introduzca un sueldo válido" });
            }

            //Fondo de Ahorro Obligatorio para la Vivienda: 1%
            decimal fao = 0.01m;
            //Seguro Social Obligatorio: 4%
            decimal sso = 0.04m;
            //Régimen Prestacional de Empleo: 0.5%
            decimal rpe = 0.005m;

            var sueldoLuegoImpuestos = sueldo - (sueldo * 0.055m);

            return Ok( new 
            { 
                sueldoFinal = sueldoLuegoImpuestos,
                fondoAhorroObligatorio = fao,
                seguroSocialObligatorio = sso,
                regimenPrestacionalDeEmpleo = rpe
            });
        }
    }
}
