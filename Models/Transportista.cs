namespace Sistema_gestion_mecanico.Models
{
    public class Transportista
    {
        public Transportista()
        {
            
        }
        public Transportista(string razoSocial, string cuil, string email, string telefono)
        {
            RazonSocial = razoSocial;
            Cuil = cuil;
            Email = email;
            Telefono = telefono;
        }
        public int Id { get; private set; }
        public string RazonSocial { get; private set; }
        public string Cuil { get; private set; }
        public string Email { get; private set; }
        public string Telefono { get; private set; }
    }
}
