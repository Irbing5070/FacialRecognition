using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using ReconocimientoFacial.Modelos;

namespace ReconocimientoFacial.Datos
{
    public class BaseDatos : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        private readonly string rutaBD;

        public BaseDatos(string rutaBD)
        {
            this.rutaBD = rutaBD;
            Database.EnsureCreated(); //crea la base de datos en caso de que no exista, si existe retorna una referencia 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IBaseDatos>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}