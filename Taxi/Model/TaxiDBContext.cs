using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Taxi.Data.Models
{
    public partial class TaxiDBContext : DbContext
    {
        public TaxiDBContext()
        {
        }

        public TaxiDBContext(DbContextOptions<TaxiDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarOptions> Caroptions { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Engine> Engine { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripType> Triptype { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=COMP3\\NEWSERVER;Database=TaxiDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<CarOptions>(entity =>
            {
                entity.ToTable("caroptions");

                entity.Property(e => e.CarOptionsId)
                    .HasColumnName("caroptions_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveAirbag).HasColumnName("active_airbag");

                entity.Property(e => e.Autopilot).HasColumnName("autopilot");

                entity.Property(e => e.EngineMode)
                    .HasColumnName("engine_mode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Multimedia).HasColumnName("multimedia");

                entity.Property(e => e.UsbPort).HasColumnName("usb_port");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("cars");

                entity.Property(e => e.CarId)
                    .HasColumnName("car_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaroptionsId).HasColumnName("caroptions_id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.EngineId).HasColumnName("engine_id");

                entity.Property(e => e.License)
                    .IsRequired()
                    .HasColumnName("license")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasColumnName("make")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caroptions)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CaroptionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cars_caroptions");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cars_company");

                entity.HasOne(d => d.Engine)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cars_engine");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .IsRequired()
                    .HasColumnName("telephone_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("driver");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driver_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .IsRequired()
                    .HasColumnName("telephone_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_driver_car");
            });

            modelBuilder.Entity<Engine>(entity =>
            {
                entity.ToTable("engine");

                entity.Property(e => e.EngineId)
                    .HasColumnName("engine_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cub).HasColumnName("cub");

                entity.Property(e => e.Cylinders).HasColumnName("cylinder");

                entity.Property(e => e.Fuel)
                    .HasColumnName("fuel")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Kmtolitre).HasColumnName("kmtolitre");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.ToTable("trips");

                entity.Property(e => e.TripId)
                    .HasColumnName("trips_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.TripTypeId).HasColumnName("triptype_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_car");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_company");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_driver");

                entity.HasOne(d => d.Triptype)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.TripTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_triptype");
            });

            modelBuilder.Entity<TripType>(entity =>
            {
                entity.ToTable("triptype");

                entity.Property(e => e.TripTypeId)
                    .HasColumnName("triptype_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasColumnName("destinatin")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasColumnName("origin")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.TimeLeaveArrive)
                    .HasColumnName("Tleave_Tarive")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_company");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_driver_user");
            });
        }
    }
}
