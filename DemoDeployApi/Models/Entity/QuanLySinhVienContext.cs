using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoDeployApi.Models.Entity;

public partial class QuanLySinhVienContext : DbContext
{
    public QuanLySinhVienContext()
    {
    }

    public QuanLySinhVienContext(DbContextOptions<QuanLySinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DeTai> DeTais { get; set; }

    public virtual DbSet<GiangVien> GiangViens { get; set; }

    public virtual DbSet<HuongDan> HuongDans { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiangVien>(entity =>
        {
            entity.Property(e => e.MaKhoa).IsFixedLength();
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.Property(e => e.MaKhoa).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
