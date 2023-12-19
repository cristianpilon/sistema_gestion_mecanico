using System.ComponentModel.DataAnnotations;

namespace Sistema_gestion_mecanico.Models
{
    public class Cliente
    {
        private Cliente()
        {

        }
        public Cliente(string nombre, string apellido, string dni, string direccion, Localidad localidad, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Localidad = localidad;
            Email = email;

        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni { get; private set; }
        public string Direccion { get; private set; }
        public string Email { get; private set; }
        public Localidad Localidad { get; private set; }
    }
}
