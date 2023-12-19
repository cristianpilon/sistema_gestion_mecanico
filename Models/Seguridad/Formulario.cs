namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Formulario
    {
        public Formulario(string descripcion, List<Accion> acciones, Modulo modulo)
        {
            Descripcion = descripcion;
            Acciones = acciones;
            Modulo = modulo;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public ICollection<Accion> Acciones { get; private set; }
        public Modulo Modulo { get; private set; }
    }
}
