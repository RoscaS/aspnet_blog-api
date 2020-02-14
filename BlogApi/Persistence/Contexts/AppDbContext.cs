using BlogApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder mb) {
            base.OnModelCreating(mb);

            mb.Entity<Category>().ToTable("Categories");
            mb.Entity<Category>().HasKey(p => p.Id);
            mb.Entity<Category>()
              .Property(p => p.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

            mb.Entity<Category>()
              .Property(p => p.Name)
              .IsRequired()
              .HasMaxLength(30);

            mb.Entity<Category>()
              .HasMany(p => p.Articles)
              .WithOne(p => p.Category)
              .HasForeignKey(p => p.CategoryId);
            

            mb.Entity<Article>().ToTable("Articles");
            mb.Entity<Article>().HasKey(p => p.Id);
            mb.Entity<Article>()
              .Property(p => p.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

            mb.Entity<Article>()
              .Property(p => p.Title)
              .IsRequired()
              .HasMaxLength(50);

            mb.Entity<Article>()
              .Property(p => p.Body)
              .IsRequired()
              .HasMaxLength(10000);
            
            
            
            // Hardcoding some dummy data
            mb.Entity<Category>().HasData(
              new Category {Id = 100, Name = "Technologies"},
              new Category {Id = 101, Name = "Politique"}
            );
            
            mb.Entity<Article>().HasData
            (
              new Article
              {
                Id = 100,
                Title = "Intel new cpu",
                Body = "Lorem ...",
                CategoryId = 100
              },
              new Article
              {
                Id = 101,
                Title = "Nancy Pelosy is dum !",
                Body = "Lorem ...",
                CategoryId = 101,
              }
            );
        }
    }
}
