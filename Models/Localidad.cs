namespace Sistema_gestion_mecanico.Models
{
    public class Localidad
    {
        public Localidad()
        {
        }
        public Localidad(string nombre_loc)
        {
            Nombre_loc = nombre_loc;
        }
        public int Id { get; private set; }
        public string Nombre_loc { get; private set; }
        public int ProvinciaId { get; private set; }
        public Provincia Provincia { get; private set; }
    }
}
