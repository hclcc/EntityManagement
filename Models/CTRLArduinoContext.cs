using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Arduino.Models;

public partial class CTRLArduinoContext : DbContext
{
    public CTRLArduinoContext(DbContextOptions<CTRLArduinoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LogAction> LogActions { get; set; }

    public virtual DbSet<Valvula> Valvulas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<LogAction>(entity =>
        {
            entity.Property(e => e.DateExec).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Valvula>(entity =>
        {
            entity.Property(e => e.IdValve).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
