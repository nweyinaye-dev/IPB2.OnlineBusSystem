using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBusDetail> TblBusDetails { get; set; }

    public virtual DbSet<TblPayment> TblPayments { get; set; }

    public virtual DbSet<TblRoute> TblRoutes { get; set; }

    public virtual DbSet<TblSchedule> TblSchedules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=IPB2_OnlineBusBooking;User ID=sa;Password=sasa@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBusDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_BusD__3214EC0710818D4B");

            entity.ToTable("Tbl_BusDetail");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.BusName).HasMaxLength(100);
            entity.Property(e => e.BusNo).HasMaxLength(10);
            entity.Property(e => e.BusType).HasMaxLength(10);
        });

        modelBuilder.Entity<TblPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Paym__3214EC070A51E68F");

            entity.ToTable("Tbl_Payment");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.BookId).HasMaxLength(100);
            entity.Property(e => e.CardNo).HasMaxLength(50);
            entity.Property(e => e.Payment).HasMaxLength(50);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Rout__3214EC071BD6EB66");

            entity.ToTable("Tbl_Route");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.Destination).HasMaxLength(100);
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.RouteName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Sche__3214EC07E61E4650");

            entity.ToTable("Tbl_Schedule");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.ArrivalTime).HasMaxLength(20);
            entity.Property(e => e.BusId).HasMaxLength(100);
            entity.Property(e => e.DepartureTime).HasMaxLength(20);
            entity.Property(e => e.RouteId).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
