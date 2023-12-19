namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Grupo
    {

        public Grupo()
        {
                
        }

        public Grupo(string descripcion)
        {
            this.Descripcion = descripcion;
        }


        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual List<Permiso> Permisos { get; set; }
    }
}
