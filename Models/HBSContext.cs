using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HBSApi.Models
{
    public partial class HBSContext : DbContext
    {
        public HBSContext()
        {
        }

        public HBSContext(DbContextOptions<HBSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingStatus> BookingStatus { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        // Unable to generate entity type for table 'dbo.Rating'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=hbs-database-public.chnk1cocv8yq.us-east-2.rds.amazonaws.com;Database=HBS;User Id=admin;Password=bookingsystem1;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.BusinessName).HasMaxLength(50);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasMaxLength(10);

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TableNumber).HasMaxLength(10);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Booking_Customer");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Staff");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_Booking_BookingStatus1");
            });

            modelBuilder.Entity<BookingStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerId).HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Feedback1).HasColumnName("Feedback");

                entity.Property(e => e.StaffId).HasMaxLength(10);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Booking");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Feedback_Customer");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_Feedback_Staff");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Account");
            });
        }
    }
}
