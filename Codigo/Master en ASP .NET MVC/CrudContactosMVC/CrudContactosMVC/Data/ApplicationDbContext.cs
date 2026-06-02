using CrudContactosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudContactosMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        // Aqui se define el DbSet para la entidad Contacto
        public DbSet<Contacto> Contactos { get; set; }
    }
}
