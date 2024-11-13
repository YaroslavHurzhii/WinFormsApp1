using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class DBContext : DbContext
    {
        public DbSet<Assignment> Tasks { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "data.db")}");
        }

        public static void InitializeDatabase()
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating database: {ex.Message}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasKey(t => t.AssignmentID);

                entity.Property(t => t.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(t => t.Description)
                    .HasMaxLength(1000);

                entity.HasOne(t => t.Priority)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(t => t.PriorityID)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(t => t.Status)
                    .WithMany(s => s.Tasks)
                    .HasForeignKey(t => t.StatusID)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasKey(p => p.PriorityID);

                entity.Property(p => p.PriorityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasData(
                    new Priority { PriorityID = 1, PriorityName = "Low" },
                    new Priority { PriorityID = 2, PriorityName = "Mid" },
                    new Priority { PriorityID = 3, PriorityName = "High" }
                );
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(s => s.StatusID);

                entity.Property(s => s.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasData(
                    new Status { StatusID = 1, StatusName = "New" },
                    new Status { StatusID = 2, StatusName = "In progress" },
                    new Status { StatusID = 3, StatusName = "Completed" }
                );
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
