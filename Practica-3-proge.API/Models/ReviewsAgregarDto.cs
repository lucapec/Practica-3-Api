using System.ComponentModel.DataAnnotations;

namespace Practica_3_proge.API.Models
{
    public class ReviewsAgregarDto
    {
        [Required(ErrorMessage = "Agrega tu nombre")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
