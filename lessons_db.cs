using System;
using System.Collections.Generic;
using Hotel;
using Microsoft.EntityFrameworkCore;

namespace Hotel;

public partial class lessons_db : DbContext
{
    public lessons_db()
    {
    }

    public lessons_db(DbContextOptions<lessons_db> options)
        : base(options)
    {
    }

    public virtual DbSet<Addictive> Addictives { get; set; }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<AppCategory> AppCategorys { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<TelephonCall> TelephonCalls { get; set; }

    public virtual DbSet<UsedAddictive> UsedAddictives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=root;database=lessons_db", ServerVersion.Parse("8.0.29-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Addictive>(entity =>
        {
            entity.HasKey(e => e.AddId).HasName("PRIMARY");

            entity.ToTable("addictives");

            entity.Property(e => e.AddId).HasColumnName("add_id");
            entity.Property(e => e.AddName)
                .HasColumnType("text")
                .HasColumnName("add_name");
            entity.Property(e => e.AddPrice).HasColumnName("add_price");
        });

        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.ApId).HasName("PRIMARY");

            entity.ToTable("apartment");

            entity.HasIndex(e => e.ApCategotyId, "ap_categoty_id");

            entity.HasIndex(e => e.ApId, "apartment_id").IsUnique();

            entity.Property(e => e.ApId).HasColumnName("ap_id");
            entity.Property(e => e.ApCapacity).HasColumnName("ap_capacity");
            entity.Property(e => e.ApCategotyId).HasColumnName("ap_categoty_id");
            entity.Property(e => e.ApNumber).HasColumnName("ap_number");

            entity.HasOne(d => d.ApCategoty).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.ApCategotyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apartment_ibfk_1");
        });

        modelBuilder.Entity<AppCategory>(entity =>
        {
            entity.HasKey(e => e.CatgId).HasName("PRIMARY");

            entity.ToTable("app_categorys");

            entity.Property(e => e.CatgId).HasColumnName("catg_id");
            entity.Property(e => e.CatgName)
                .HasColumnType("text")
                .HasColumnName("catg_name");
            entity.Property(e => e.PrcOnePr).HasColumnName("prc_one_pr");
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.GId).HasName("PRIMARY");

            entity.ToTable("guest", tb => tb.HasComment("Info about guests and keys"));

            entity.HasIndex(e => e.ApId, "ap_id");

            entity.HasIndex(e => e.GTelNumId, "g_tel_num_id").IsUnique();

            entity.Property(e => e.GId)
                .HasComment("Guest's id")
                .HasColumnName("g_id");
            entity.Property(e => e.ApId).HasColumnName("ap_id");
            entity.Property(e => e.GTelNumId).HasColumnName("g_tel_num_id");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.OutTime).HasColumnName("out_time");
            entity.Property(e => e.SecondName)
                .HasColumnType("text")
                .HasColumnName("second_name");
            entity.Property(e => e.Surname)
                .HasColumnType("text")
                .HasColumnName("surname");

            entity.HasOne(d => d.Ap).WithMany(p => p.Guests)
                .HasForeignKey(d => d.ApId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guest_ibfk_1");
        });

        modelBuilder.Entity<TelephonCall>(entity =>
        {
            entity.HasKey(e => e.CallId).HasName("PRIMARY");

            entity.ToTable("telephon_calls");

            entity.HasIndex(e => e.CallNumId, "call_num_id_guest_id");

            entity.Property(e => e.CallId).HasColumnName("call_id");
            entity.Property(e => e.CallDate)
                .HasColumnType("datetime")
                .HasColumnName("call_date");
            entity.Property(e => e.CallNum)
                .HasMaxLength(12)
                .HasColumnName("call_num");
            entity.Property(e => e.CallNumId).HasColumnName("call_num_id");

            entity.HasOne(d => d.CallNumNavigation).WithMany(p => p.TelephonCalls)
                .HasPrincipalKey(p => p.GTelNumId)
                .HasForeignKey(d => d.CallNumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("telephon_calls_ibfk_1");
        });

        modelBuilder.Entity<UsedAddictive>(entity =>
        {
            entity.HasKey(e => e.UAddId).HasName("PRIMARY");

            entity.ToTable("used_addictives");

            entity.HasIndex(e => e.AddId, "add_id");

            entity.HasIndex(e => e.GId, "g_id");

            entity.Property(e => e.UAddId).HasColumnName("u_add_id");
            entity.Property(e => e.AddId).HasColumnName("add_id");
            entity.Property(e => e.GId).HasColumnName("g_id");

            entity.HasOne(d => d.Add).WithMany(p => p.UsedAddictives)
                .HasForeignKey(d => d.AddId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("used_addictives_ibfk_2");

            entity.HasOne(d => d.GIdNavigation).WithMany(p => p.UsedAddictives)
                .HasForeignKey(d => d.GId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("used_addictives_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
