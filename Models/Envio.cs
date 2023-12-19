namespace Sistema_gestion_mecanico.Models
{
    public class Envio
    {
        public Envio()
        {
            
        }

        public Envio(Rectificado rectificado, EstadoEnvio estadoEnvio)
        {
            Rectificado = rectificado;
            EstadoEnvio = estadoEnvio;
        }

        public int Id { get; private set; }
        public Rectificado Rectificado { get; private set; }
        public EstadoEnvio EstadoEnvio { get; private set; }
        public DateTime? FechaEnvio { get; private set; }
        public Transportista? Transportista { get; private set; }

        public void setEstadoYFecha(EstadoEnvio estadoEnvio, DateTime fechaEnvio, Transportista transportista)
        {
            EstadoEnvio = estadoEnvio;
            FechaEnvio = fechaEnvio;
            Transportista = transportista;
        }

    }
}
