using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class Subject : BaseEntity
{
    // Properties

    [Column(TypeName = "nvarchar(100)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";
}