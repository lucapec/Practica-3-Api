using Microsoft.AspNetCore.Mvc;

namespace Practica_3_proge.API.Controllers
{
    [ApiController]
    [Route("api/peliculas/{idPelicula}")]
    public class ReviewsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ReviewsDto>>GetReviews(int idPelicula)
        {
            var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (pelicula == null)
                return NotFound();
            return Ok(pelicula.Reviews);

        }

        [HttpGet("{idReviews}", Name = "GetReviews")]
        public ActionResult<ReviewsDto>GetReviews(int idPelicula, int idReview)
        {
            var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (pelicula == null)
                return NotFound();
            var reviews = pelicula.Reviews.FirstOrDefault(x => x.Id == idReview);
            if (reviews == null)
                return NotFound(reviews);
            return Ok(reviews);
        }
    }
}
