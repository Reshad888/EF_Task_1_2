using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class Group : BaseEntity
{
    // Properties

    [Column(TypeName = "nvarchar(20)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "Year is required")]
    [Range(1, 5, ErrorMessage = "Must be between 1 and 5")]
    public int Year { get; set; }

    // Foreign Keys

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "DepartmentId is required")]
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }

    // Navigation Properties

    public Department Department { get; set; }
    public ICollection<GroupCurator> Groups_GroupsCurators { get; set; }
    public ICollection<GroupLecture> Groups_GroupsLectures { get; set; }
    public ICollection<GroupStudent> Groups_GroupsStudents { get; set; }
}