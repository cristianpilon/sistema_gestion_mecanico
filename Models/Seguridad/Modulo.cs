namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Modulo
    {
        public Modulo(string descripcion, List<Formulario> formularios)
        {
            Descripcion = descripcion;
            Formularios = formularios;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public ICollection<Formulario> Formularios { get; private set; }
    }
}
