using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xavier_Gordillo
{
    public class Gordillo
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        [Range(1, 8)]
        public int Cantidad { get; set; }

        [Required]
        [DataType(DataType.Currency)] 
        public decimal Precio { get; set; } 

        [Required]
        public required string Descripcion { get; set; }

        public bool Activo { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public virtual required Gordillo Relacionado { get; set; } 
    }
}

