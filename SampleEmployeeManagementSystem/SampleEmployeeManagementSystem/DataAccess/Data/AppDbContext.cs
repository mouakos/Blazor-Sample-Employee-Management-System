using Microsoft.EntityFrameworkCore;
using SampleEmployeeManagementSystem.DataAccess.Entities;
using SampleEmployeeManagementSystem.DataAccess.Extensions;

namespace SampleEmployeeManagementSystem.DataAccess.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.GenerateSeed();
    }
}