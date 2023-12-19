namespace Sistema_gestion_mecanico.Models.MongoDb
{
    public class SGMecanicoDbSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string CollectionName { get; set; } = null!;
    }
}
