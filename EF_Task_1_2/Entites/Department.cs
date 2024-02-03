using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace EF_Task_1_2.Entites;

public class Department : BaseEntity
{
    // Properties

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "Building is required")]
    [Range(1, 5, ErrorMessage = "Must be between 1 and 5")]
    public int Building { get; set; }

    [Column(TypeName = "money")]
    [Required(ErrorMessage = "Financing is required")]
    [Range(0, double.MaxValue, ErrorMessage = "Financing must be a non-negative value")]
    public double Financing { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    // Foreign Keys

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "FacultyId is required")]
    [ForeignKey("Faculty")]
    public int FacultyId { get; set; }

    // Navigation Properties

    public Faculty Faculty { get; set; }
    public ICollection<Group> Groups { get; set; }
}