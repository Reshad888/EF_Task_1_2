using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class Curator : BaseEntity
{
    // Properties

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "Name";

    [Column(TypeName = "nvarchar(max)")]
    [Required(ErrorMessage = "Surname is required")]
    public string Surname { get; set; } = "Surname";

    // Navigation Properties

    public ICollection<GroupCurator> Curators { get; set; }
}