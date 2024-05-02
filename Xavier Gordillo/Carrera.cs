using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Xavier_Gordillo
{
    public class Carrera
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public required string NombreCarrera { get; set; }

        [Required]
        public required string Campus { get; set; }

        [Range(1, 9)]
        public int NumeroSemestres { get; set; }
    }
    

}
