namespace Ejercicios_Insystech_C_.DTOs
{
    public class TasaDivisaDTO
    {
        public DateTimeOffset FechaActualizacion { get; set; }
        public string Tasa { get; set; }
        public decimal Precio { get; set; }
        public string Moneda { get; set; }
    }
}
