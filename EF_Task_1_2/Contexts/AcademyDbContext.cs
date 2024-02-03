using EF_Task_1_2.Entites;
using Microsoft.EntityFrameworkCore;

namespace EF_Task_1_2.Contexts;

public class AcademyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source = DESKTOP-RH41O1K\\SQLEXPRESS;" +
            "Initial Catalog = AcademyDB__;" +
            "Integrated Security = True;" +
            "Connect Timeout = 30;" +
            "Encrypt = True;" +
            "Trust Server Certificate = True;" +
            "Application Intent = ReadWrite;" +
            "Multi Subnet Failover = False";

        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set; }
    public DbSet<GroupLecture> GroupsLectures { get; set; }
    public DbSet<GroupStudent> GroupsStudents { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}