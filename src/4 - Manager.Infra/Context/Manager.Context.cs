using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context{
    public class ManagerContext : DbContext{
        public ManagerContext()
        {}

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=USERMANAGERAPI;Trusted_Connection=True;");// @"Data Source=Ronni\SQLEXPRESS;Database=master;Integrated Security=true;Connect Timeout=30;User Instance=True; Encrypt=False; TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubNetFailover=False
        }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}