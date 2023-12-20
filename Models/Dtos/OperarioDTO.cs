namespace Sistema_gestion_mecanico.Models.Dtos
{
    public class OperarioDTO
    {
        public string? Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
