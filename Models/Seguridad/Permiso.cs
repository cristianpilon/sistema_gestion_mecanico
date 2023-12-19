using System.Runtime.CompilerServices;

namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Permiso
    {
        public Permiso()
        {
            
        }
        public Permiso(string descripcion)
        {
            this.Descripcion = descripcion;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public string NombrePermiso { get; set; }
        public List<Grupo> Grupos { get; private set; }

    }
}
