using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class Student : BaseEntity
{
    // Properties

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "Rating is required")]
    [Range(0, 5, ErrorMessage = "Must be between 0 and 5")]
    public int Rating { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Surname is required")]
    public string Surname { get; set; } = "Surname";

    // Navigation Properties

    public ICollection<GroupStudent> Students { get; set; }
}