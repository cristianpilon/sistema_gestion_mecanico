namespace Sistema_gestion_mecanico.Models.Dtos
{
    public class RectificadoDTO
    {
        public int ClienteID { get; set; }
        public int OperarioID { get; set; }
        public List<Motor>? Motores { get; set; }
        public bool ParaEnvio { get; set; }
    }
}
