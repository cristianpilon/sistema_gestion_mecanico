namespace Sistema_gestion_mecanico.Models
{
    public class Provincia
    {
        public Provincia()
        {
            
        }
        public Provincia(string nombre_prov)
        {
            Nombre_prov = nombre_prov;
        }
        public int Id { get; private set; }
        public string Nombre_prov { get; private set; }
    }
}
