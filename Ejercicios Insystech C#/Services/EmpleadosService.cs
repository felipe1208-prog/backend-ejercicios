using Ejercicios_Insystech_C_.DTOs;
using System.Collections.Generic;

namespace Ejercicios_Insystech_C_.Services
{
    public class EmpleadosService
    {
        private readonly List<EmpleadosDTO> Empleados = new List<EmpleadosDTO>
        {
            new EmpleadosDTO { Id = 1, Nombre = "Felipe Ortiz" },
            new EmpleadosDTO { Id = 2, Nombre = "Javier Rojas" },
            new EmpleadosDTO { Id = 3, Nombre = "Gilman Perez" },
            new EmpleadosDTO { Id = 4, Nombre = "Francisco Chacon" },
            new EmpleadosDTO { Id = 5, Nombre = "Victor Piedra" },
            new EmpleadosDTO { Id = 6, Nombre = "Gregory Gomez" },
            new EmpleadosDTO { Id = 7, Nombre = "Diego Quintero" },
            new EmpleadosDTO { Id = 8, Nombre = "Jose Rangel" },
            new EmpleadosDTO { Id = 9, Nombre = "Alejandro Avendano" },
            new EmpleadosDTO { Id = 10, Nombre = "Freddy Borjas" },
            new EmpleadosDTO { Id = 11, Nombre = "David Perez" },
            new EmpleadosDTO { Id = 12, Nombre = "Jesus Paredes" },
            new EmpleadosDTO { Id = 13, Nombre = "Jose Pascia" }
        };
    public List<EmpleadosDTO> ObtenerEmpleados()
        {
            return Empleados;
        }

    }

}
