using Practica_3_proge.API.Controllers;

namespace Practica_3_proge.API.Models
{
    public class PeliculasDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sinopsis { get; set; } = string.Empty;

        public ICollection<ReviewsDto> Reviews { get; set; } = new List<ReviewsDto>();

   
    }
}
