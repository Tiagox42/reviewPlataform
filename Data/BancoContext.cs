using Microsoft.EntityFrameworkCore;
using reviewPlataform.Models.Media;
using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes;
using reviewPlataform.Models.User;

namespace reviewPlataform.Data
{
    public class AppDbContext : DbContext
    {

        public IConfiguration _config { get; set; }

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        //Mídias
        public DbSet<Movie> Movie { get; set; } 
        public DbSet<Game> Game { get; set; }
        public DbSet<TesteMedia> TesteMedia { get; set; }


        //Outros
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get;}

    }
}
