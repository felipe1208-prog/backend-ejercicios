using Ejercicios_Insystech_C_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio4Controller : ControllerBase
    {
        private readonly EmpleadosService _empleados;

        public Ejercicio4Controller(EmpleadosService empleados)
        {
            _empleados = empleados;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarEmpleado([FromQuery] string? termino)
        {

            if (string.IsNullOrWhiteSpace(termino) || string.IsNullOrEmpty(termino)) return BadRequest(new { mensaje = "Ingrese un término de busqueda válido" });
            
            var listaEmpleados = _empleados.ObtenerEmpleados();

            var empleadosFiltrados = listaEmpleados
                .Where(x => x.Nombre.ToLower().Contains(termino.ToLower()) || x.Id.ToString().Contains(termino))
                .ToList();

            if (!empleadosFiltrados.Any()) return NotFound( new { mensaje = $"Nose se han encontrado resultados para: {termino}"});

            return Ok( new { resultados =  empleadosFiltrados });  
        }
    }
}
