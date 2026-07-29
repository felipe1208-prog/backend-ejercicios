using Ejercicios_Insystech_C_.DTOs;
using Ejercicios_Insystech_C_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasasDivisasController : ControllerBase
    {
        private static AlmacenTasas _almacen;

        public TasasDivisasController( AlmacenTasas almacen)
        {
            _almacen = almacen;
        }

        [HttpPost]
        public async Task<IActionResult> GuardarTasa([FromBody] TasaDivisaDTO request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            _almacen.TasasRegistradas.Add(request);

            return Ok(new { mensaje = "Tasa Registrada" });
        }
    }
}
