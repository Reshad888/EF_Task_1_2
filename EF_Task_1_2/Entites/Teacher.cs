using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace EF_Task_1_2.Entites;

public class Teacher : BaseEntity
{
    // Properties

    [Column(TypeName = "bit")]
    [Required(ErrorMessage = "IsProfessor is required")]
    public bool IsProfessor { get; set; } = false;

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    [Column(TypeName = "money")]
    [Required(ErrorMessage = "Salary is required")]
    [Range(0, double.MaxValue, ErrorMessage = "Financing must be a non-negative value")]
    public double Salary { get; set; } = 0;

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Surname is required")]
    public string Surname { get; set; } = "Surname";

    // Navigation Properties

    public ICollection<Lecture> Lectures { get; set; }
}