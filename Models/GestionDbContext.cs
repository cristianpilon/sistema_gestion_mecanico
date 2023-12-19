using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models.Seguridad;

namespace Sistema_gestion_mecanico.Models
{
    public class GestionDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public GestionDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          //  modelBuilder.Entity<Cliente>().HasData(
          //      new Cliente("Lautaro", "Cabral", "39505005", "Sgto cabral 576", "Rosario", "lautacabral96@gmail.com"),
          //    new Cliente("Florencia", "Montini", "39505005", "Nazca 8870", "Rosario", "lautacabral96@gmail.com")
          //  ); ;
          //  modelBuilder.Entity<Empleado>().HasData(
          //      new Empleado("Negocio 1", "Op", "39505005", "Caja"),
          //   new Empleado("Negocio 2", "Neg", "39505005", "Deposito")
          //  );
          //  modelBuilder.Entity<Estado>().HasData(
          //       new Estado("Ingresado"),
          //       new Estado("Taller"),
          //       new Estado("Completo")
          //  );
          //  modelBuilder.Entity<EstadoEnvio>().HasData(
          //     new EstadoEnvio("Pendiente"),
          //     new EstadoEnvio("Para despacho"),
          //     new EstadoEnvio("Despachado")
          //);
          //  modelBuilder.Entity<Insumo>().HasData(
          //      new Insumo("Pistón", 10, 19.99m),
          //      new Insumo("Cilindro", 15, 29.99m),
          //      new Insumo("Biela", 20, 9.99m),
          //      new Insumo("Cárter", 8, 49.99m),
          //      new Insumo("Árbol de levas", 12, 39.99m),
          //      new Insumo("Válvula de admisión", 25, 14.99m),
          //      new Insumo("Válvula de escape", 25, 14.99m),
          //      new Insumo("Árbol de transmisión", 5, 79.99m),
          //      new Insumo("Bujía", 30, 2.99m),
          //      new Insumo("Polea", 18, 8.99m),
          //      new Insumo("Radiador", 10, 69.99m),
          //      new Insumo("Filtro de aire", 40, 4.99m),
          //      new Insumo("Cojinete", 15, 6.99m),
          //      new Insumo("Embrague", 12, 49.99m),
          //      new Insumo("Bomba de agua", 8, 39.99m),
          //      new Insumo("Junta de culata", 6, 19.99m),
          //      new Insumo("Sistema de escape", 10, 29.99m),
          //      new Insumo("Cadena de distribución", 15, 19.99m),
          //      new Insumo("Sensor de oxígeno", 20, 34.99m),
          //      new Insumo("Árbol de levas", 12, 29.99m),
          //      new Insumo("Polea  del cigüeñal", 10, 9.99m),
          //      new Insumo("Sistema de dirección", 5, 59.99m),
          //      new Insumo("Bomba de aceite", 8, 29.99m),
          //      new Insumo("Válvula EGR", 15, 39.99m),
          //      new Insumo("Termostato", 12, 14.99m),
          //      new Insumo("Sistema de frenos", 20, 49.99m),
          //      new Insumo("Sonda lambda", 15, 24.99m),
          //      new Insumo("Turbocompresor", 8, 149.99m),
          //      new Insumo("Correa de distribución", 10, 12.99m),
          //      new Insumo("Aceite del motor", 50, 7.99m)
          //      );
          //  modelBuilder.Entity<Operario>().HasData(
          //       new Operario("Operario 1", "Op", "39505005", DateTime.Today),
          //       new Operario("Operario 1", "Op", "39505005", DateTime.Today)
          //  );
          //  modelBuilder.Entity<Proveedor>().HasData(
          //       new Proveedor("Keller"),
          //       new Proveedor("Corven")
          //  );
          //  modelBuilder.Entity<Transportista>().HasData(
          //       new Transportista("Viacargo", "2039505005", "Viacargo@gmail.com", "3412621001"),
          //       new Transportista("PackageGo", "2039505225", "PackageGo@gmail.com", "3412621001")
          //  );
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<EstadoEnvio> EstadoEnvios { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<LineaPedido> LineaPedidos { get; set; }
        public DbSet<LineaVenta> LineaVenta { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Motor> Motores { get; set; }
        public DbSet<OcCount> OcCounts { get; set; }
        public DbSet<Operario> Operarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Rectificado> Rectificados { get; set; }
        public DbSet<Transportista> Transportistas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        //Security
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }


    }
}
