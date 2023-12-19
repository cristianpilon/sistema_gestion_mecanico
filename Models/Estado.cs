namespace Sistema_gestion_mecanico.Models
{
    public class Estado
    {
        private Estado()
        {

        }
        public Estado(string descripcion)
        {
            Descripcion = descripcion;
        }
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
    }
}
