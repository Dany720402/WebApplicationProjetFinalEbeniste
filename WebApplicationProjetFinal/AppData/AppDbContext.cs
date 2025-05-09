




using Microsoft.EntityFrameworkCore;
using WebApplicationProjetFinal.Models; // si vos entités sont dans Models

namespace WebApplicationProjetFinal.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Meuble> Meubles { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Client> Clients { get; set; }


        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrdersItems { get; set; }

        public DbSet<ShoppingCarItem> ShoppingCarItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unicité sur Style.Nom
            modelBuilder.Entity<Style>()
                .HasIndex(s => s.Nom)
                .IsUnique();

            // Unicité sur Client.Email
            modelBuilder.Entity<Client>()
                .HasIndex(c => c.Email)
                .IsUnique();

            // Relation Meuble → Style
            modelBuilder.Entity<Meuble>()
                .HasOne(m => m.Style)
                .WithMany(s => s.Meubles)
                .HasForeignKey(m => m.StyleID);
        }
    }

}





