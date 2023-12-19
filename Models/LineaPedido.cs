namespace Sistema_gestion_mecanico.Models
{
    public class LineaPedido
    {
        private LineaPedido()
        {

        }
        public LineaPedido(Insumo insumo, int cantidad, decimal precio)
        {
            Insumo = insumo;
            Cantidad = cantidad;
            Precio = precio;
        }

        //public void setCant(int cantidad)
        //{
        //    Cantidad = cantidad;
        //}

        public int Id { get;  private set; }
        public Insumo Insumo { get; private set; }
        public int Cantidad { get; private set; }
        public decimal Precio { get; private set; }


    }
}
