using System;
using System.Collections.Generic;
using EFDatabaseFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDatabaseFirstDemo.Data;

public partial class TestEfdatabaseApprochContext : DbContext
{
    public TestEfdatabaseApprochContext()
    {
    }

    public TestEfdatabaseApprochContext(DbContextOptions<TestEfdatabaseApprochContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:EFDBCon");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CD19B026F0");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductDesciption)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ProductRate).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
