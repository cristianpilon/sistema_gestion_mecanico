using System.ComponentModel.DataAnnotations;

namespace Sistema_gestion_mecanico.Models
{
    public class Motor
    {
        private Motor()
        {

        }
        public Motor(string marca, string modelo, DateTime fabricacion, string nroMotor)
        {
            NroMotor = nroMotor;
            Marca = marca;
            Modelo = modelo;
            Fabricacion = fabricacion;
        }
        public int Id { get; private set; }
        public string NroMotor { get; set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public DateTime Fabricacion { get; private set; }
    }
}
