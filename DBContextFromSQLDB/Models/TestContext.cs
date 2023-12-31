﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBContextFromSQLDB.Models;

public partial class TestContext : DbContext
{
    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SomeTable> SomeTables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SomeTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SomeTabl__3214EC0734998C47");

            entity.ToTable("SomeTable");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Data).HasMaxLength(100);
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}