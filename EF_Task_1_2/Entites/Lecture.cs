using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class Lecture : BaseEntity
{
    // Properties

    [Column(TypeName = "date")]
    [Required(ErrorMessage = "DateLecture is required")]
    public DateTime DateLecture { get; set; }

    // Foreign Keys

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "SubjectId is required")]
    [ForeignKey("Subject")]
    public int SubjectId { get; set; }

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "TeachertId is required")]
    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }

    // Navigation Properties

    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }
    public ICollection<GroupLecture> Lectures { get; set; }
}