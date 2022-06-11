using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_BackEnd_Eterna.Models;

namespace Project_BackEnd_Eterna.DAL
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Statistics> Statistics { get; set; }


    }
}
