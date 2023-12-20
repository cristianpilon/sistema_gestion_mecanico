using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Sistema_gestion_mecanico.Models.Dtos;

namespace Sistema_gestion_mecanico.Models.MongoDb
{
    public class Operario
    {
        public Operario(OperarioDTO operario)
        {
            Id = operario.Id;
            Nombre = operario.Nombre;
            Apellido = operario.Apellido;
            Dni = operario.Dni;
            Fecha = operario.Fecha;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Nombre { get; private set; } = null!;
        public string Apellido { get; private set; } = null!;
        public string Dni { get; private set; } = null!;
        public DateTime Fecha { get; private set; }

    }
}
