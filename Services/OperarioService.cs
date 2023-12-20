using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Sistema_gestion_mecanico.Models.Dtos;
using Sistema_gestion_mecanico.Models.MongoDb;

namespace Sistema_gestion_mecanico.Services
{
    public class OperarioService
    {
        private readonly IMongoCollection<Operario> _operariosCollection;

        public OperarioService(IOptions<SGMecanicoDbSettings> sgmecanicoDbSettings)
        {
            var mongoClient = new MongoClient(
                sgmecanicoDbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                sgmecanicoDbSettings.Value.DatabaseName);

            _operariosCollection = mongoDatabase.GetCollection<Operario>(
                sgmecanicoDbSettings.Value.CollectionName);
        }

        public async Task<List<Operario>> GetAsync() =>
            await _operariosCollection.Find(_ => true).ToListAsync();

        public async Task<Operario?> GetAsync(string id) =>
            await _operariosCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(OperarioDTO newOperario)
        {
            var operario = new Operario(newOperario);

            await _operariosCollection.InsertOneAsync(operario);
        }

        public async Task UpdateAsync(string id, OperarioDTO updatedOperario)
        {
            var operario = new Operario(updatedOperario);

            await _operariosCollection.ReplaceOneAsync(x => x.Id == id, operario);
        }

        public async Task RemoveAsync(string id) =>
            await _operariosCollection.DeleteOneAsync(x => x.Id == id);
    }
}
