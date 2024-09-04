using AcademiaHub.Models;
using Microsoft.EntityFrameworkCore;

public class AcademiaHubContext : DbContext
{
    public AcademiaHubContext(DbContextOptions<AcademiaHubContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Guardian> Guardians { get; set; }
    public DbSet<Hostel> Hostels { get; set; }
    public DbSet<Hosteler> Hostelers { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Class> Classes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Student Entity
        modelBuilder.Entity<Student>()
            .HasKey(s => s.EnrollmentNo);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Class)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.ClassID);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Section)
            .WithMany(se => se.Students)
            .HasForeignKey(s => s.SectionID);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Parent)
            .WithMany()
            .HasForeignKey(s => s.ParentID);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Guardian)
            .WithMany()
            .HasForeignKey(s => s.GuardianID);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.Hostel)
            .WithMany()
            .HasForeignKey(s => s.HostelID);

        // Parent Entity
        modelBuilder.Entity<Parent>()
            .HasKey(p => p.ParentID);

        // Guardian Entity
        modelBuilder.Entity<Guardian>()
            .HasKey(g => g.GuardianID);

        // Hostel Entity
        modelBuilder.Entity<Hostel>()
            .HasKey(h => h.HostelID);

        modelBuilder.Entity<Hostel>()
            .HasMany(h => h.Hostelers)
            .WithOne(ho => ho.Hostel)
            .HasForeignKey(ho => ho.HostelID);

        // Hosteler Entity
        modelBuilder.Entity<Hosteler>()
            .HasKey(h => h.HostelerID);

        modelBuilder.Entity<Hosteler>()
            .HasOne(h => h.Student)
            .WithMany(st => st.Hostelers)
            .HasForeignKey(h => h.EnrollmentNo);

        // Section Entity
        modelBuilder.Entity<Section>()
            .HasKey(s => s.SectionID);

        modelBuilder.Entity<Section>()
            .HasMany(s => s.Students)
            .WithOne(st => st.Section);

        // Class Entity
        modelBuilder.Entity<Class>()
            .HasKey(c => c.ClassId);

        modelBuilder.Entity<Class>()
            .HasMany(c => c.Students)
            .WithOne(st => st.Class);
    }
}
