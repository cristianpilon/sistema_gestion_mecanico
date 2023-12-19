namespace Sistema_gestion_mecanico.Models
{
    public class Insumo
    {
        private Insumo()
        {

        }
        public Insumo(string nombre, int stock, decimal precio)
        {
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public int Stock { get; private set; }
        public decimal Precio { get; private set; }

    }
}
