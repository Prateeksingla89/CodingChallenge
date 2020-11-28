using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooManagemetSystem.Model;

namespace ZooManagemetSystem
{
    public class ZooContext : DbContext
    {
        private readonly string connectionString;
        public ZooContext(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }
        public ZooContext()
        {
        }

        public ZooContext(DbContextOptions<ZooContext> options)
            : base(options)
        {
        }

        public DbSet<ZooModel> ZooModels { get; set; }
        public DbSet<ZooAnimalMappingModel> ZooAnimalMappingModels { get; set; }
        public DbSet<ZooKeeperMappingModel> ZooKeeperMappingModel { get; set; }
        public DbSet<KeeperStatusModel> KeeperStatusModels { get; set; }
        public DbSet<KeeperModel> KeeperModels { get; set; }
        public DbSet<AnimalModel> AnimalModels { get; set; }
        public DbSet<AnimalCategory> AnimalCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Connectionstring");

            }
        }
    }
}
