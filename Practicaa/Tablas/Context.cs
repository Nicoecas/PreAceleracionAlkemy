using Microsoft.EntityFrameworkCore;

namespace Practica.Tablas
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("Estoy conectando el programa con la base de datos");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8L5QFE6\SQLEXPRESS;Initial Catalog=Blog;Trusted_Connection=True;");
        }

        //Entities
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
