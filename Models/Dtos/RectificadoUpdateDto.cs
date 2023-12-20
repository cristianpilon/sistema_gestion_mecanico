namespace Sistema_gestion_mecanico.Models.Dtos
{
    public class RectificadoUpdateDto
    {
        public string ClienteId { get;  set; }
        public string OperarioId { get;  set; }
        public int EstadoId { get;  set; }
        public bool ParaEnvio { get;  set; }
    }
}
