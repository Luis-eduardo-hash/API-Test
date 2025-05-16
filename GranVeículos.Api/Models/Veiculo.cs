using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GranVeículos.Api.Models
{ 
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Modelo { get; set; }
        [ForeignKey("ModeloId")]
        public Modelo modelo { get; set; }

        [Required]
        public short AnoFabricacao { get; set; }

        [Required]
        public short AnoModelo { get; set; }

        [Required]
        public int CorId { get; set; }
        [ForeignKey("CorId")]
        public Cor Cor { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Valor { get; set; }
      
        [StringLength(7)]
        public string Placa { get; set; }
    }
}