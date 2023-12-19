namespace Sistema_gestion_mecanico.Models.Dtos
{
    public class RectificadoUpdateDto
    {
        public Cliente Cliente { get; private set; }
        public Operario Operario { get; private set; }
        public List<Motor> Motores { get; private set; }
        public Estado Estado { get; private set; }
        public bool ParaEnvio { get; private set; }
    }
}
