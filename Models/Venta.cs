namespace Sistema_gestion_mecanico.Models
{
    public class Venta
    {
        public Venta()
        {
            
        }
        public Venta(Empleado empleado, Cliente cliente, DateTime fecha, List<LineaVenta> lineasVentas)
        {
            Empleado = empleado;
            Cliente = cliente;
            Fecha = fecha;
            LineasVenta = lineasVentas;
        }

        public int Id { get; private set; }
        public Empleado Empleado { get; private set; }
        public Cliente Cliente { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<LineaVenta> LineasVenta { get; private set; }

    }
}
