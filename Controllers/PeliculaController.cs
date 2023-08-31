using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkingTime.Entities;
using WorkingTime.DTOs;

namespace WorkingTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {

        [HttpGet]
        [Route("Peliculas")]
        public IActionResult Peliculas()
        {
            return Ok("Todas las peliculas");
        }


        [HttpPost]
        [Route("Agregar")]
        public IActionResult Agregar(PeliculaDto pelicula)
        {
            return Unauthorized("No se pudo agregar proyecto");
        }


        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarPelicula(PeliculaDto pelicula)
        {
            return Ok(pelicula);
        }


        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarPelicula(int id)
        {
            return Ok($"Se elimino el elemento {id} correctamente"); 
        }                                                            
    }
}
