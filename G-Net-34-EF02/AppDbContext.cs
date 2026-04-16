using G_Net_34_EF02.Configration;
using G_Net_34_EF02.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_EF02
{
    internal class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=true;TrustServerCertificate=true");
        }
        
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Attendee>()
                .OwnsOne(a => a.Address);
            modelBuilder.ApplyConfiguration(new BadgeConfigration());

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.Description)
                .HasMaxLength(500);


            });
            modelBuilder.Entity<Organizer>()
                .HasMany(o => o.Events)
                .WithOne(e => e.Organizer)
                .HasForeignKey(e => e.OrganizerId);

            modelBuilder.Entity<Attendee>()
                .HasMany(a => a.Events)
                .WithMany(e => e.Attendees)
                .UsingEntity(j=>j.ToTable("EventRegistrations"));

            modelBuilder.Entity<Event>()
                .HasMany(e=>e.Sessions)
                .WithOne(e=>e.ParentEvent)
                .HasForeignKey(e=>e.ParentEventId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
