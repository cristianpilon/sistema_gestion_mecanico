namespace Sistema_gestion_mecanico.Models
{
    public class Empleado
    {
        public Empleado()
        {
                
        }
        public Empleado(string nombre, string apellido, string dni, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cargo = cargo;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni { get; private set; }
        public string Cargo { get; private set; }

    }
}
