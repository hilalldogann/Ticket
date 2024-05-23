using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Ticket.Models;

namespace Ticket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Activity>().HasKey(am => new
            {
                am.ActorId,
                am.ActivityId
            });
            modelBuilder.Entity<Actor_Activity>().HasOne(m => m.Activity).WithMany(am => am.Actors_Activities).HasForeignKey(m => m.ActivityId);
            modelBuilder.Entity<Actor_Activity>().HasOne(m => m.Actor).WithMany(am => am.Actors_Activities).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
            
        public DbSet<Activity> Activities { get; set; }

        public DbSet<Actor_Activity> Actors_Activities{ get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }
        


        //orders tables

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }



    }
}
