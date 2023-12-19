namespace Sistema_gestion_mecanico.Models
{
    public class Rectificado
    {
        public Rectificado()
        {

        }

        public Rectificado(Cliente cliente, Operario operario, List<Motor> motores, List<Pedido> pedidos, DateTime fecha, Estado estado, decimal total, bool paraEnvio)
        {
            Cliente = cliente;
            Operario = operario;
            Motores = motores;
            Pedidos = pedidos;
            Fecha = fecha;
            Estado = estado;
            Total = total;
            ParaEnvio = paraEnvio;
        }

        public int Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public Operario Operario { get; private set; }
        public List<Motor> Motores { get; private set; }
        public List<Pedido>? Pedidos { get; private set; }
        public DateTime Fecha { get; private set; }
        public Estado Estado { get; private set; }
        public decimal Total { get; private set; }
        public bool ParaEnvio { get; private set; }

        public void Update(Cliente cliente, Operario operario, List<Motor> motores, Estado estado, bool paraEnvio)
        {
            Cliente = cliente;
            Operario = operario;
            Motores = motores;
            Estado = estado;
            ParaEnvio = paraEnvio;
        }
    }
}
