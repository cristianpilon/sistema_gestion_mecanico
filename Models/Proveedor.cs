namespace Sistema_gestion_mecanico.Models
{
    public class Proveedor
    {
        private Proveedor()
        {

        }
        public Proveedor(string nombre)
        {
            Nombre = nombre;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
    }
}
