namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Accion
    {
        public Accion()
        {
            
        }
        public Accion(string descripcion)
        {
            this.Descripcion = descripcion;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public ICollection<Formulario> Formularios { get; set; }
    }
}
