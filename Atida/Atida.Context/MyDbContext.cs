using Atida.Repositories.Entities;
using Atida.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Atida.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AtidaDB;Trusted_Connection=True");
        }
    }
}