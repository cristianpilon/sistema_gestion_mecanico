namespace Sistema_gestion_mecanico.Models
{
    public class LineaVenta
    {
        public LineaVenta()
        {
            
        }
        public LineaVenta(decimal precio, int cantidad, Insumo insumo)
        {
            Precio = precio;
            Cantidad = cantidad;
            Insumo = insumo;
        }
        public int Id { get; private set; }
        public decimal Precio { get; private set; }
        public int Cantidad { get; private set; }
        public Insumo Insumo { get; private set; }
    }
}
