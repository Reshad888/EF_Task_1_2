using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class GroupStudent : BaseEntity
{
    // Foreign Keys

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "GroupId is required")]
    [ForeignKey("Group")]
    public int GroupId { get; set; }

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "StudentId is required")]
    [ForeignKey("Student")]
    public int StudentId { get; set; }

    // Navigation Properties

    public Group Group { get; set; }
    public Student Student { get; set; }
}