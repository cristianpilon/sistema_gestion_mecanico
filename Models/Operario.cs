namespace Sistema_gestion_mecanico.Models
{
    public class Operario
    {
        private Operario()
        {

        }
        public Operario(string nombre, string apellido, string dni, DateTime fecha)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Fecha = fecha;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni { get; private set; }
        public DateTime Fecha { get; private set; }

    }
}
