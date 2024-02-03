using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Task_1_2.Entites;

public class GroupCurator : BaseEntity
{
    // Foreign Keys

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "GroupId is required")]
    [ForeignKey("Group")]
    public int GroupId { get; set; }

    [Column(TypeName = "int")]
    [Required(ErrorMessage = "GroupId is required")]
    [ForeignKey("Curator")]
    public int CuratorId { get; set; }

    // Navigation Properties

    public Group Group { get; set; }
    public Curator Curator { get; set; }
}