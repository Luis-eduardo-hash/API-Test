using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GranVeículos.Api.Models
{
    [Table("Cor")]
    public class Cor
    {
      [Key]  
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Nome { get; set; }  
    }
}