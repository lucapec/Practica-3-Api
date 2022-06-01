using Microsoft.AspNetCore.Mvc;
using Practica_3_proge.API.Models;

namespace Practica_3_proge.API.Controllers
{
    [ApiController]
    [Route("api/peliculas/{idPelicula}/reviews")]
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
        public ActionResult<ReviewsDto>GetReviews(int idPelicula, int idReviews)
        {
            var pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (pelicula == null)
                return NotFound();
            var reviews = pelicula.Reviews.FirstOrDefault(x => x.Id == idReviews);
            if (reviews == null)
                return NotFound(reviews);
            return Ok(reviews);
        }

        [HttpPost(Name ="AgragarReviews")]
        public ActionResult<ReviewsDto> AgregarReviews(int idPelicula, ReviewsAgregarDto reviews)
        {
            var review= PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (review is null)
            {
                return NotFound();
            }

            var idMaximoReviews= PeliculasData.InstanciaActual.Peliculas.SelectMany(c => c.Reviews).Max(p => p.Id);

            var nuevaReview = new ReviewsDto
            {
                Id = ++idMaximoReviews,
                Name = reviews.Name,
                Description = reviews.Description,
            };

            review.Reviews.Add(nuevaReview);

            return CreatedAtRoute(//CreatedAtRoute es para q devuelva 201, el 200 de post.
                "GetReviews", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros q necesita ese endpoint
                {
                    idPelicula,
                    IdReviews = nuevaReview.Id
                },
                nuevaReview);//El tercero es el objeto creado. 
        }

        [HttpPut("{IdReviews}", Name ="AcutalizarReviews")]
        public ActionResult ActualizarReviews(int idPelicula, int IdReviews, ReviewsAgregarDto reviews)
        {
            var review = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (review == null)
                return NotFound();
            var reviewsBase = review.Reviews.FirstOrDefault(x => x.Id == IdReviews);
            if (reviewsBase == null)
                return NotFound();

            reviewsBase.Name = reviews.Name;
            reviewsBase.Description = reviews.Description;

            return NoContent();
        }
        [HttpDelete(Name ="BorrarReview")]
        public ActionResult BorrarReview(int idPelicula, int idReviews)
        {
            var review = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(c => c.Id == idPelicula);
            if (review is null)
                return NotFound();

            var reviewAEliminar = review.Reviews.FirstOrDefault(x => x.Id == idReviews);
            if (reviewAEliminar is null)
                return NotFound();

            review.Reviews.Remove(reviewAEliminar);

            return Ok();
        }
    }
}
