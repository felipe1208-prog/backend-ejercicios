using Ejercicios_Insystech_C_.DTOs;
using Ejercicios_Insystech_C_.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasasDivisasController : ControllerBase
    {
        private static AlmacenTasas _almacen;

        public TasasDivisasController(AlmacenTasas almacen)
        {
            _almacen = almacen;
        }

        //Endpoint de registro de tasa en vista inicio
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


        //Endpoint para las 3 vistas de las divisas
        [HttpGet("{tasa}")]
        public async Task<IActionResult> ObtenerTasasRegistradas(string tasa)
        {
            if (tasa == null)
            {
                return BadRequest();
            }

            var tasasRegistradaPorDivisa = _almacen.TasasRegistradas
                .Where(x => x.Tasa == tasa)
                .Select(x => new TasaDivisaDTO
                {
                    FechaActualizacion = x.FechaActualizacion,
                    Tasa = x.Tasa,
                    Precio = x.Precio,
                    Moneda = x.Moneda
                })
                .ToList();

            if (!tasasRegistradaPorDivisa.Any()) 
            {
                return NotFound(new { mensaje = "Aún no hay registros para esta tasa. Te invitamos a registrar una en la sección 'Tasas del Día'" });
            }

            return Ok(tasasRegistradaPorDivisa);
        }
    }
}
