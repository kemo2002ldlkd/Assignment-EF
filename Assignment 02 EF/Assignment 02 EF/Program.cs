using Assignment_02_EF;
using Microsoft.EntityFrameworkCore;

public class ITIDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Stud_Course> Stud_Courses { get; set; }
    public DbSet<Course_Inst> Course_Insts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One-to-Many Relationship
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.Dep_Id);

        // Many-to-Many Relationships
        modelBuilder.Entity<Stud_Course>()
            .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

        modelBuilder.Entity<Course_Inst>()
            .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your_Connection_String_Here");
    }
}

