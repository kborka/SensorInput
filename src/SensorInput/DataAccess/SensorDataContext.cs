using Microsoft.EntityFrameworkCore;
using SensorInput.Models;

namespace SensorInput.DataAccess;

internal partial class SensorDataContext : DbContext
{
    private readonly string connectionString;

    public SensorDataContext(DataUploadConnectionInfo dbConnectionInfo)
    {
        connectionString = dbConnectionInfo.ConnectionString;
    }

    public DbSet<SensorData>? SensorData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SensorData>(entity =>
        {
            entity.HasNoKey();
            entity.Property(t => t.Time).IsRequired();
            entity.Property(t => t.Temperature).IsRequired();
            entity.Property(t => t.Humidity).IsRequired();
            entity.Property(t => t.Pressure).IsRequired();
            entity.Property(t => t.Gas).IsRequired();
            entity.Property(t => t.AirQuality).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
