using System.ComponentModel.DataAnnotations;

namespace Practica_3_proge.API.Models
{
    public class PeliculasCrearDto
    {
        [Required(ErrorMessage = "Agrega la pelicuila que hayas visto")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Sinopsis { get; set; } = string.Empty;
    }
}
