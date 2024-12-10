﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace moviesAPI.Models;

public partial class MoviedbContext : DbContext
{
    public MoviedbContext()
    {
    }

    public MoviedbContext(DbContextOptions<MoviedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=FRANK-XPS-24\\SQLEXPRESS;Initial Catalog=moviedb; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movies");  // Tell it the table name

            entity.HasKey(e => e.MovieId).HasName("PK__Movies__42EB374E9F2AAF3A");

            entity.Property(e => e.MovieId).HasColumnName("movieId");
            entity.Property(e => e.Director)
                .HasMaxLength(200)
                .HasColumnName("director");
            entity.Property(e => e.ReleaseYear).HasColumnName("releaseYear");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
