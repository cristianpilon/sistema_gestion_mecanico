namespace Sistema_gestion_mecanico.Models.Seguridad
{
    public class Usuario
    {

        public Usuario()
        {
            
        }

        public Usuario(string nombre, string user, string password, string email, List<Grupo> grupos)
        {
            Nombre = nombre;
            User = user;
            Password = password;
            Email = email;
            Grupo = grupos;
        }
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public ICollection<Grupo> Grupo { get; private set; }

    }
}
