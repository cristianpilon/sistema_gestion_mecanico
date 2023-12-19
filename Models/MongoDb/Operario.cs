using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Sistema_gestion_mecanico.Models.MongoDb
{
    public class Operario
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Nombre { get; private set; } = null!;
        public string Apellido { get; private set; } = null!;
        public string Dni { get; private set; } = null!;
        public DateTime Fecha { get; private set; }

    }
}
