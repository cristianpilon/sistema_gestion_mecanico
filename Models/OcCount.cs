namespace Sistema_gestion_mecanico.Models
{
    public class OcCount
    {
        public OcCount()
        {
            
        }
        public OcCount(int ultimaOc)
        {
            UltimaOc = ultimaOc;
        }
        public int Id { get; private set; }
        public int UltimaOc { get; private set; }
        public void setUltimaOc(int nuevaOc)
        {
            UltimaOc = nuevaOc;
        }
    }
}
