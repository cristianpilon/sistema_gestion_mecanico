namespace Sistema_gestion_mecanico.Models.Dtos
{
    public class RectificadoResponseDTO
    {
        public RectificadoResponseDTO()
        {

        }

        public RectificadoResponseDTO(int id,Cliente cliente, Operario operario, List<Motor> motores, DateTime fecha, Estado estado, decimal total, bool paraEnvio)
        {
            Id = id;
            Cliente = cliente;
            Operario = operario;
            Motores = motores;
            Fecha = fecha;
            Estado = estado;
            Total = total;
            ParaEnvio = paraEnvio;
        }

        public int Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public Operario Operario { get; private set; }
        public List<Motor> Motores { get; private set; }
        public DateTime Fecha { get; private set; }
        public Estado Estado { get; private set; }
        public decimal Total { get; private set; }
        public bool ParaEnvio { get; private set; }

    }
}
