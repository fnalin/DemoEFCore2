using Microsoft.EntityFrameworkCore;

namespace DemoEF
{
    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;DataBase=Livraria;Uid=root;Pwd=123456@qwerty");
        }

        public EFCoreDemoContext()
        {
            Database.EnsureCreated();
        }
    }
}
