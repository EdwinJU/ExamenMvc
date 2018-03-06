using Microsoft.EntityFrameworkCore;

namespace ExamenMvc.Models
{
    public class MvcExamenContext : DbContext
    {
        public MvcExamenContext (DbContextOptions<MvcExamenContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenMvc.Models.Usuario> Usuario { get; set; }

        public DbSet<ExamenMvc.Models.Post> Cliente { get; set; }

       
    }
}