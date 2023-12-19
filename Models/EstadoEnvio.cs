namespace Sistema_gestion_mecanico.Models
{
    public class EstadoEnvio
    {
        public EstadoEnvio()
        {
            
        }
        public EstadoEnvio(string descripcion)
        {
            Descripcion = descripcion;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
    }
}
