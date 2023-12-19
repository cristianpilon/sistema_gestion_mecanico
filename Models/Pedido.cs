namespace Sistema_gestion_mecanico.Models
{
    public class Pedido
    {
        private Pedido()
        {

        }
        public Pedido(Proveedor proveedor, DateTime fecha, List<LineaPedido> lineaPedidos, bool estado, bool pedidoTaller)
        {
            Proveedor = proveedor;
            Fecha = fecha;
            LineasDePedido = lineaPedidos;
            Estado = estado; // hace referencia si fue pedido para emitir orden de compra
            PedidoTaller = pedidoTaller; // hace referencia a si es pedido de taller hecho por operario o negocio desde 0
        }
        public int Id { get; private set; }
        public Proveedor Proveedor { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<LineaPedido> LineasDePedido { get; private set; }
        public bool Estado { get; private set; }
        public int NroOrdenCompra { get; private set; }
        public DateTime FechaOrdenCompra { get; private set; }
        public bool PedidoTaller { get; private set; }
        public void setOrdenCompra(int nroOrdenCompra, DateTime fechaOrdenCompra)
        {
            NroOrdenCompra = nroOrdenCompra;
            FechaOrdenCompra = fechaOrdenCompra;

        }
    }
}
