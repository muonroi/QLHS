using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_C_
{
    public class School_DbContext : DbContext
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        }
        );
        public DbSet<Students> students { get; set; }
        public DbSet<Teacher> teacher { get; set; }
        string dbo = @"
            ADDR = localhost,1433;
            Database = Schools;
            UID = sa;
            PWD = Password123;
        ";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(dbo);
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>(
                (entity =>
                {
                    entity.HasIndex(index => index.StudentCode).IsUnique(true);
                    entity.Property(index => index.Classroom).IsRequired(false);
                }
                )
            );
            modelBuilder.Entity<Teacher>(entity => {entity.HasIndex(index => index.ClassRoom).IsUnique(true); });
        }
    }
}