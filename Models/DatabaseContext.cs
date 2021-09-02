using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppMVC.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            base.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { ID = 1, Username = "onurkagan", Password = "123", Ad = "Onur Kağan" },
                new User() { ID = 2, Username = "admin", Password = "123", Ad = "Administrator" }
                );

            modelBuilder.Entity<Todo>().HasData(
                new Todo() { ID = 1, UserID = 1, Description = "Ders Çalış" },
                new Todo() { ID = 3, UserID = 1, Description = "Projeyi tamamla" }
                );
        }
    }
}
