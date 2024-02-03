using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Task_1_2.Entites;

public class Faculty : BaseEntity
{
    // Properties

    [Column(TypeName = "nvarchar(100)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    // Navigation Properties

    public ICollection<Department> Departments { get; set; }
}