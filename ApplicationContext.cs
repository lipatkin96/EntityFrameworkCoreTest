using System;
using System.Collections.Generic;
using System.Text;
	
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreConsoleApp1
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=exampledb;
                            Username=lipatkin;Password=qwerty;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // using Fluent API
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.ToTable("Users", "public");

        //        entity.Property(e => e.Id)
        //                            .HasColumnName("id")
        //                            .HasDefaultValueSql("nextval('public.users_id_seq'::regclass)");

        //        entity.Property(e => e.Age).HasColumnName("age");

        //        entity.Property(e => e.Name)
        //                            .IsRequired()
        //                            .HasColumnName("name");
        //    });

        //    modelBuilder.HasSequence("users_id_seq", "public");
        //}
    }
}

