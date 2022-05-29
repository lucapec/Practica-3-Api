using Microsoft.AspNetCore.Mvc;
using Practica_3_proge.API.Models;

namespace Practica_3_proge.API.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculasController : ControllerBase
    {
        [HttpGet]
           public ActionResult<IEnumerable<PeliculasDto>> GetPeliculas()
            {
                return Ok(PeliculasData.InstanciaActual.Peliculas);
            }
        [HttpGet("{id}")]
        public ActionResult<PeliculasDto> GetPelicula(int id)
        {
            var peliculaADevolver = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if (peliculaADevolver == null)
                return NotFound();
            return Ok(peliculaADevolver);
        }

        [HttpDelete("{id}")]
        public ActionResult<PeliculasDto> DeletePelicula(int id)
        {
            var peliculaABorrar = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if (peliculaABorrar == null)
                return NotFound();
            return Ok();
        }
        

    }
}
