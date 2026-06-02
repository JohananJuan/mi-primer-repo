using BlogCoreSolution.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlogCoreSolution.AccesoDatos.Data
{
    // Clase
    public class ApplicationDbContext : IdentityDbContext
    {

        // Contructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }

    }

}
