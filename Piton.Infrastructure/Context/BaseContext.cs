using Microsoft.EntityFrameworkCore;
using Piton.Entities.EF;
using System;

namespace Piton.Infrastructure.Context
{
    public  class BaseContext: DbContext 
    {
        public BaseContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PitonDb;Trusted_Connection=true");
        }

        public DbSet<Activity> Activity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }
        public BaseContext(DbContextOptions<BaseContext> options)
        : base(options)
        {
        }

    }
}
